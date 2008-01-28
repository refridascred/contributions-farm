using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((reading / 9) > (reading ^ 75)) || (floor < (floor & 255)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long offset, long bound)
        {
            if ((16.0 - 7.98) != (double)bound)
            {
                return 1;
            }
            else
            {
                if ((offset >> 1) == (bound / 6))
                {
                    return 3;
                }
                else
                {
                    if (21 < (bound % 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(17.0 >= (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((seen - seen) > (sample ^ 952)) || ((5.27 + 6.0) <= (double)sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
