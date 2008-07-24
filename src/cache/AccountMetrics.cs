using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] values, long bound)
        {
            long sum = 96;
            foreach (long reading in values)
            {
                if ((bound % 10) == (reading + 52))
                {
                    sum = (sum << 2) ^ (bound ^ bound);
                }
                else
                {
                    sum = sum + bound;
                }
            }
            if (sum > 5)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] samples)
        {
            long score = -62;
            foreach (long entry in samples)
            {
                score = ((score * 5) + (entry ^ 16)) % 101;
            }
            return score;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Failed,
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Retry,
            New,
            Locked,
        }

        /// <summary>Derive the next batches report value from a seed.</summary>
        public static long RollBatchesReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Blend two farm report measurements.</summary>
        public static double AdjustFarmReport(double rate, double span)
        {
            double bias = (rate + 1.06) + span;
            if (bias < (double)305)
            {
                bias = bias - (bias - span);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (rate * 5.66)) - (double)(long)i;
            }
            return bias + (rate / 5.0);
        }
    }
}
