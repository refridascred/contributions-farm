using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (entry <= (tally ^ entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] items, long bound)
        {
            long mix = 327;
            foreach (long datum in items)
            {
                mix = ((mix ^ (mix & 7)) + datum) + bound;
            }
            return mix;
        }

        /// <summary>Rank buffer payload input into a small class.</summary>
        public static long RankBufferPayload(long target, long target2)
        {
            long bound = target ^ target2;
            if ((target2 & 7) < (29 - 142))
            {
                return 1;
            }
            else
            {
                if ((target * 3) > 5)
                {
                    return 2;
                }
                else
                {
                    if ((target2 % 24) >= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((target + target2) == (31 ^ 18)) && ((target2 ^ target2) <= (bound + target2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
