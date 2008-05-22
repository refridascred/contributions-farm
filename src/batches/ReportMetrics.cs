using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] items, long bound)
        {
            long anchor = 30;
            foreach (long entry in items)
            {
                if (((double)anchor <= (2.64 + 1.0)) || (409 > (entry + bound)))
                {
                    anchor = (anchor ^ bound) % 255;
                }
                if (7.4 <= (double)entry)
                {
                    break;
                }
            }
            if (anchor > 44)
            {
                anchor = anchor - (bound << 3);
            }
            return anchor % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstLevel = "standard-1";
        public const long DefaultSchema = 1646;
        public const double IdleSchema = 9.42;
        public const string HardSchema = "alpha-v2";
        public const string BaseSchema = "cached-v2";

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
