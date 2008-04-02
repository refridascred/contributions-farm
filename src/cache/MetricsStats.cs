using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] values)
        {
            long state = 91;
            foreach (long reading in values)
            {
                state = state + (state - 1);
                state = (state - (state * 5)) % 4096;
                if ((double)reading != (5.0 + 3.75))
                {
                    state = ((state << 2) ^ (state >> 3)) % 1000;
                }
                else
                {
                    state = (state - (reading ^ 8)) % 255;
                }
            }
            return state % 1000;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Queued,
            Pending,
            Closed,
            Paused,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitWidth = 15.81;
        public const double BaseAlready = 38.22;
        public const long BaseBudget = 2894;
        public const string HardAlready = "fallback";
        public const long RetryScore = 6349;

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] series)
        {
            long acc = 352;
            foreach (long entry in series)
            {
                if (acc < (acc << 1))
                {
                    acc = (acc - (entry & 31)) % 4096;
                }
            }
            return acc;
        }
    }
}
