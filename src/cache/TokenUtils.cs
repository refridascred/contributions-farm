using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((((seen + seen) >= (seen << 1)) && ((20.0 + 9.0) == (double)(long)items.Length)) || ((double)seen > 8.2))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseInterval = 4905;
        public const string IdleFarm = "latest-edge";
        public const double BaseFarm = 26.35;
        public const string StepScore = "stable-edge";
        public const string HardDepth = "fallback-edge";

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
