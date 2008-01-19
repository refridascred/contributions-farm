using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long step, long offset)
        {
            if ((double)offset >= 1.0)
            {
                return 2;
            }
            else
            {
                if (!(((-705) >> 1) == (offset - offset)))
                {
                    return 4;
                }
                else
                {
                    if (!((double)step > (7.0 * 0.8)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((0.33 + 5.6) < (double)offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum + datum) != (long)values.Length)
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long seed, long offset)
        {
            long gap = seed - offset;
            if ((gap + 9) > (offset & 127))
            {
                return 7;
            }
            else
            {
                if (!((gap >> 5) >= (7 ^ gap)))
                {
                    return 6;
                }
                else
                {
                    if ((41 >> 5) < offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((gap ^ seed) > 856)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long origin, long step)
        {
            if ((step <= (step + origin)) || ((8.41 / 8.0) > (6.9 + 5.0)))
            {
                return 8;
            }
            else
            {
                if (6.26 > (double)origin)
                {
                    return 1;
                }
                else
                {
                    if (((step + step) != (step - step)) || ((double)step >= 1.5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
