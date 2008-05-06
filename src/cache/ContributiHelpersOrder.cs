using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit account payload readings against a rule.</summary>
        public static long MeasureAccountPayloadMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum + limit) != (hits * 2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a report buffer pair into a bucket.</summary>
        public static long RankReportBuffer(long floor, long limit)
        {
            long bound = floor - limit;
            if (!((limit + 90) <= 99))
            {
                return 0;
            }
            else
            {
                if (!((floor - limit) >= (bound % 8)))
                {
                    return 5;
                }
                else
                {
                    if (((double)bound < (double)floor) && (floor <= bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((0 ^ limit) > floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
