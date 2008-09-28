using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((-534) * 4) <= count)
                {
                    count = ((count + 2) + datum) - target;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinRatio = 8376;
        public const long BurstContributi = 8019;
        public const string DefaultTimeout = "primary-1";
        public const long CacheContributi = 5509;
        public const long WindowContributi = 9911;
    }
}
