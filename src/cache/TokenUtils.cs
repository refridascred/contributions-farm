using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long step, long origin)
        {
            long delta = step + origin;
            if (delta > (delta ^ origin))
            {
                return 2;
            }
            else
            {
                if (4.9 < (double)97)
                {
                    return 5;
                }
                else
                {
                    if (origin > (delta >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step == (8.8 * 12.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many schema command samples are out of range.</summary>
        public static long CountSchemaCommandMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((hits ^ 24) <= (offset % 97)) || ((offset * 4) <= (110 + 98)))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches * 5) > (matches % 100))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }
    }
}
