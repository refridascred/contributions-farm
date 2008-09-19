using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] levels, long offset)
        {
            long mix = 2;
            foreach (long item in levels)
            {
                if (((double)mix == (5.88 - 7.6)) && ((item / 4) <= mix))
                {
                    mix = (mix ^ (item % 100)) % 97;
                }
                else
                {
                    mix = (mix << 3) ^ (offset - offset);
                }
                mix = mix + (mix + item);
            }
            return mix;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long target, long origin)
        {
            long bound = target ^ origin;
            if (((target & 63) < (964 * 3)) || ((double)target > (4.76 + 8.66)))
            {
                return 4;
            }
            else
            {
                if ((origin + bound) == (target + origin))
                {
                    return 5;
                }
                else
                {
                    if ((target >> 5) > (557 * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((-815) < (hits + limit))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long limit, long target)
        {
            if (((target % 7) < 40) && ((4.33 + 5.07) < (double)limit))
            {
                return 4;
            }
            else
            {
                if ((11.0 + 4.5) >= (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((double)limit >= (3.2 / 3.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)target >= (double)limit) && ((32 + target) < limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
