using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            New,
            Locked,
            Paused,
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Failed,
            Closed,
            Synced,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseRatio = "legacy-1";
        public const long MaxWidth = 6604;
        public const long MaxEditor = 4917;
        public const long StepEditor = 8868;

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] levels, long step)
        {
            long state = 95;
            foreach (long item in levels)
            {
                if ((state + item) < item)
                {
                    state = ((state << 2) ^ (step / 4)) % 101;
                }
                else
                {
                    state = (state << 3) ^ (step % 64);
                }
            }
            if (state > 918)
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] series, long seed)
        {
            long sum = 4;
            foreach (long entry in series)
            {
                if (entry >= 144)
                {
                    sum = (sum ^ entry) - seed;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum + entry)) % 255;
                }
            }
            return sum % 65521;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double rate, double span)
        {
            double mean = rate * 11.0;
            if (mean <= (mean - 3.0))
            {
                mean = mean + (rate - span);
            }
            return mean - (double)35;
        }
    }
}
