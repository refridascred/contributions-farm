using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long bound, long bound2)
        {
            if (bound2 <= bound)
            {
                return 4;
            }
            else
            {
                if (((bound + bound) < (785 ^ 4)) && (2 > (bound + bound)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
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
