using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstEditor = "standard-edge";
        public const double SoftRatio = 86.75;
        public const long WindowEditor = 1427;
        public const long BaseWidth = 6244;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((long)readings.Length < (seen + seen))
                {
                    seen = ((seen + 1) + entry) + floor;
                }
            }
            return seen;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen + seen) >= seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
