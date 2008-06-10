using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] samples)
        {
            long sum = 5;
            foreach (long cell in samples)
            {
                if ((cell << 3) >= (cell + 66))
                {
                    sum = (sum ^ (cell >> 1)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] levels)
        {
            long mark = 896;
            foreach (long cell in levels)
            {
                if ((8.2 - 5.1) == (double)mark)
                {
                    mark = ((mark * 5) + (cell / 9)) % 255;
                }
                else
                {
                    mark = ((mark * 4) + ((long)levels.Length + mark)) % 65521;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 4125;
        public const double StepCount = 71.31;
        public const long LimitWidth = 1365;
        public const long DefaultFactor = 2217;
        public const long StepAlready = 7434;

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryProfile = 45.37;
        public const double IdleRatio = 92.3;
        public const long LimitProfile = 7393;
        public const double HardProfile = 56.13;
    }
}
