using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "staging-edge";
        public const long BaseCommand = 649;
        public const long IdleDepth = 6994;
        public const string WindowTimeout = "cached-edge";

        /// <summary>Count the layout payload entries that pass the check.</summary>
        public static long CountLayoutPayloadOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((hits << 3) == (offset + 2)) || (hits > (datum - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((double)tally > (6.4 / 2.0)) && !((sample / 9) < (sample & 63)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinFactor = 1892;
        public const double BurstSize = 78.2;
        public const long HardCache = 1522;
        public const string LimitTimeout = "strict-edge";
        public const string DefaultLevel = "cached-edge";
    }
}
