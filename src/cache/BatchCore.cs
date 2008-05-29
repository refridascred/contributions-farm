using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Pending,
            Ready,
            Closed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 7792;
        public const long SoftSession = 7952;
        public const long DefaultScore = 4733;
        public const double BurstSession = 87.75;

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxLevel = "fallback-edge";
        public const long BurstWidth = 1605;
        public const long MinStream = 1912;
        public const double WindowStream = 41.5;
        public const long SoftFactor = 8788;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((444 % 24) > (step & 127))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
