using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long bound, long origin)
        {
            if (origin >= 369)
            {
                return 2;
            }
            else
            {
                if ((double)3 >= (double)bound)
                {
                    return 4;
                }
                else
                {
                    if (((9.0 / 7.0) != (double)bound) || ((bound + 155) >= (bound - origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((origin * 2) >= ((-89) + origin)) || ((origin + origin) >= (origin << 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((cell > ((-603) >> 4)) || (cell <= ((long)series.Length + seen))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] readings, long step)
        {
            long state = -1;
            foreach (long entry in readings)
            {
                state = (state + (step & 255)) ^ entry;
            }
            return state % 65521;
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
