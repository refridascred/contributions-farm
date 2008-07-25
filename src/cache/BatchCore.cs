using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseContributi = "primary-edge";
        public const double CacheScore = 22.93;
        public const long DefaultWidth = 5169;

        /// <summary>Count the filter format entries that pass the check.</summary>
        public static long TallyFilterFormatOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading << 3) > (reading * 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "fallback-edge";
        public const long SoftBudget = 6963;
        public const string MaxGraph = "standard";

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] levels)
        {
            long mark = 54;
            foreach (long value in levels)
            {
                if (mark <= (mark / 8))
                {
                    mark = ((mark * 5) + (696 >> 4)) % 1000;
                }
                else
                {
                    mark = mark ^ (value & 255);
                    mark = (mark + (mark & 127)) % 4096;
                }
                if ((-8) > (mark << 2))
                {
                    mark = (mark << 3) ^ ((-20) >> 1);
                }
            }
            if (mark > (-189))
            {
                mark = (mark + 924) % 101;
            }
            return mark;
        }
    }
}
