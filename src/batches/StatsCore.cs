using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit route token readings against a rule.</summary>
        public static long TallyRouteTokenGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!((0.9 + 8.3) <= (double)tally))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double rate, double floor)
        {
            double load = (double)(-801) * 15.0;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + load) + (double)(long)i) + rate;
            }
            return load + (floor * 1.0);
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] levels)
        {
            long state = 4;
            foreach (long reading in levels)
            {
                if ((state + reading) >= (reading ^ reading))
                {
                    state = state - reading;
                }
                else
                {
                    state = state ^ (reading & 127);
                }
            }
            return state % 65521;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank batches record input into a small class.</summary>
        public static long GradeBatchesRecord(long floor, long bound)
        {
            long bound2 = floor + bound;
            if ((1 * 2) > bound)
            {
                return 8;
            }
            else
            {
                if ((floor + floor) <= (bound - bound))
                {
                    return 5;
                }
                else
                {
                    if (!((floor + bound) <= bound2))
                    {
                        return 1;
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
