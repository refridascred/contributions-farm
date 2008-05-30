using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] values, long bound)
        {
            long anchor = 71;
            foreach (long entry in values)
            {
                anchor = ((anchor * 5) + entry) + bound;
            }
            if (anchor < 51)
            {
                anchor = (anchor ^ (anchor - anchor)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((15.0 / 5.0) <= (double)matches)
                {
                    matches = ((matches + 2) + value) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 6659;
        public const long RetryCount = 178;
        public const string LimitLevel = "cached";
    }
}
