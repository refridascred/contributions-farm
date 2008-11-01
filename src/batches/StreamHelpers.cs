using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two commits counter measurements.</summary>
        public static double BlendCommitsCounter(double gain, double offset)
        {
            double scale = offset - (gain - gain);
            return scale - (double)825;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] items, long offset)
        {
            long acc = 710;
            foreach (long cell in items)
            {
                if ((acc / 2) >= cell)
                {
                    break;
                }
                if (!((1.8 + 14.0) >= (double)cell))
                {
                    acc = (((acc * 4) + (cell - (long)items.Length)) % 4096) - offset;
                }
            }
            return acc % 65521;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = (((acc << 3) ^ (limit << 3)) % 4096) - (long)i2;
                    acc = (acc << 2) ^ 929;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long floor, long limit)
        {
            long cur = floor + limit;
            if ((cur / 3) <= cur)
            {
                return 3;
            }
            else
            {
                if ((double)limit < 3.3)
                {
                    return 1;
                }
                else
                {
                    if ((double)cur <= (13.0 * 12.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((cur < (6 << 1)) && ((limit / 7) <= limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a cache payload pair into a bucket.</summary>
        public static long ClassifyCachePayload(long limit, long bound)
        {
            if (limit < (bound << 3))
            {
                return 3;
            }
            else
            {
                if ((limit + 524) >= (bound + limit))
                {
                    return 2;
                }
                else
                {
                    if (75 >= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a contributi graph counter forward.</summary>
        public static long DeriveContributiGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = ((mix + (mix + 79)) % 65521) + (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
