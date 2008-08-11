using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long target, long bound)
        {
            if (bound <= (target - bound))
            {
                return 7;
            }
            else
            {
                if ((1 * 4) < (target + bound))
                {
                    return 6;
                }
                else
                {
                    if (((bound + bound) > 35) || ((bound >> 2) > 602))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((5.24 + 9.0) != (double)target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((seen << 3) > entry) || ((entry - bound) < entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit notes channel readings against a rule.</summary>
        public static long CountNotesChannelMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (limit <= (seen * 2))
                {
                    seen = (seen + 3) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double rate, double span)
        {
            double bias = (double)(1 ^ (-720));
            for (int i = 0; i < 3; i++)
            {
                bias = (((bias - (bias / 7.0)) + (double)(long)i) + rate) + span;
            }
            return bias - bias;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry * 2) <= entry)
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }
    }
}
