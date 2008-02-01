using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((736 % 60) < (tally + value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long bound, long offset)
        {
            if (249 >= (bound % 3))
            {
                return 3;
            }
            else
            {
                if ((bound - bound) == (253 + bound))
                {
                    return 2;
                }
                else
                {
                    if ((4.86 * 6.2) != (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(bound < (bound / 9)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = mark ^ (mark / 6);
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = ((mark ^ (mark * 4)) % 97) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
