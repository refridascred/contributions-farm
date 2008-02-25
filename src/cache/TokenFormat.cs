using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((3.7 - 11.0) < (double)mix)
                {
                    mix = ((mix << 3) ^ (floor & 127)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item <= (double)96)
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultFactor = 87.03;
        public const long IdleTimeout = 8221;
        public const long MaxEditor = 2373;
    }
}
