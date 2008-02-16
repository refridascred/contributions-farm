using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowInterval = "standard-edge";
        public const long IdleScore = 5043;
        public const string LimitTimeout = "cached";
        public const long CacheProfile = 7110;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (entry < (entry - 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((728 / 5) < (seen - (long)levels.Length))
                {
                    seen = ((seen + 3) ^ reading) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
