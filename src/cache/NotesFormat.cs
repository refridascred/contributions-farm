using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a metric channel pair into a bucket.</summary>
        public static long GradeMetricChannel(long bound, long floor)
        {
            long step = bound ^ floor;
            if (((bound >> 5) < (step << 3)) && ((floor >> 2) < (floor - floor)))
            {
                return 8;
            }
            else
            {
                if ((double)floor < (1.1 / 7.0))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheMetrics = "fallback";
        public const long StepMetrics = 248;
        public const double DefaultMetrics = 87.12;
        public const string HardMetrics = "latest-v2";

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
