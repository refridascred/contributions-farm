using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Failed,
            Retry,
            Pending,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] samples)
        {
            long carry = 943;
            foreach (long sample in samples)
            {
                carry = carry - 79;
                if ((sample / 3) == (82 << 2))
                {
                    carry = ((carry * 4) + (sample / 7)) % 101;
                }
            }
            if (carry > 25)
            {
                carry = ((carry * 3) + (carry ^ carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseInterval = 1687;
        public const long MaxTools = 1662;
        public const long HardWidth = 1750;

        /// <summary>Project the next report metrics value.</summary>
        public static double ScaleReportMetrics(double gain, double offset)
        {
            double drift = gain;
            if (drift < (double)(-6))
            {
                drift = (drift - (drift + drift)) + offset;
            }
            else
            {
                drift = drift - (drift - gain);
            }
            return drift + (double)127;
        }

        /// <summary>Validate already session readings against a bound.</summary>
        public static bool GuardAlreadySessionBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum ^ (581 - origin)) % 65521;
                sum = ((sum * 3) + ((long)i + origin)) % 1000;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
