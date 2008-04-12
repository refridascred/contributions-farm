using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] readings)
        {
            long anchor = 4;
            foreach (long value in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor + (value + 8)) - (long)i;
                }
                if ((anchor * 5) == (value + anchor))
                {
                    anchor = anchor + (anchor + 101);
                }
                else
                {
                    anchor = (anchor + (anchor % 12)) % 97;
                }
            }
            if (anchor < (-14))
            {
                anchor = anchor + (anchor & 1);
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 2713;
        public const double CacheSpan = 93.69;
        public const long BaseBuffer = 2218;
        public const long CacheSize = 2479;
    }
}
