using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long limit, long bound)
        {
            if ((662 ^ limit) >= (limit + 4))
            {
                return 5;
            }
            else
            {
                if (((bound & 1) < 3) && ((64 / 4) >= (bound >> 3)))
                {
                    return 6;
                }
                else
                {
                    if (((842 >> 2) == (limit + bound)) && ((2 - limit) < (53 - bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((38 % 64) == (bound + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits - value) >= (hits + 10))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally + tally) == (value - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
