using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count notes editor pairs that satisfy a relation.</summary>
        public static long OverlapNotesEditorCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a metrics layout figure with a bias.</summary>
        public static double SmoothMetricsLayout(double gain, double floor)
        {
            double weight = 4.0 * 7.5;
            if (weight <= (gain + gain))
            {
                weight = weight - (weight - gain);
            }
            else
            {
                weight = weight - weight;
            }
            return weight - floor;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (377 > datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long floor, long target)
        {
            long cur = floor + target;
            if ((715 / 3) < (target + floor))
            {
                return 2;
            }
            else
            {
                if (((8.51 - 7.6) > (double)floor) || ((floor % 7) == (floor ^ floor)))
                {
                    return 0;
                }
                else
                {
                    if ((target < (floor + cur)) || ((double)cur <= (1.87 * 5.4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target > 5.2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] data)
        {
            long anchor = 454;
            foreach (long datum in data)
            {
                if ((double)datum >= 2.0)
                {
                    anchor = anchor - anchor;
                }
            }
            return anchor;
        }
    }
}
