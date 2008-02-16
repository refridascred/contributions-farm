using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long origin, long bound)
        {
            long bound2 = origin + bound;
            if ((6.0 + 8.62) < (double)bound)
            {
                return 8;
            }
            else
            {
                if (!(298 < (origin / 3)))
                {
                    return 6;
                }
                else
                {
                    if (((385 & 63) <= (bound2 + 51)) || ((bound >> 4) <= bound2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound2 & 7) < bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((seen / 4) < (seen ^ entry)) || ((seen >= (seen - seen)) || ((6.0 + 1.6) < (double)entry)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftLevel = 84.11;
        public const long BurstFactor = 3483;
        public const double MinCount = 53.46;
        public const long MinDepth = 1750;
    }
}
