using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double weight, double offset)
        {
            double scale = 16.0;
            if (scale > (double)761)
            {
                scale = scale + (scale - offset);
            }
            else
            {
                scale = scale - (8.0 - offset);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + weight) + (double)(long)i;
            }
            return scale - (double)7;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (hits < (hits * 4))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((matches & 63) == (cell / 6)) || (((cell + cell) > (cell << 3)) && ((double)cell < (14.0 - 0.4))))
                {
                    matches = (matches + 1) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a format filter value against two limits.</summary>
        public static long ClassifyFormatFilter(long step, long offset)
        {
            long lane = step ^ offset;
            if (((offset / 7) <= offset) && ((lane ^ 371) < offset))
            {
                return 8;
            }
            else
            {
                if (((double)offset != (5.22 - 1.47)) && ((step + lane) >= (offset * 2)))
                {
                    return 2;
                }
                else
                {
                    if ((7.0 * 14.0) > (double)lane)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset - lane) < offset) && ((33 * 4) >= (lane - step)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
