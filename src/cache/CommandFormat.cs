using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long origin, long floor)
        {
            long delta = origin - floor;
            if ((double)delta >= (double)636)
            {
                return 3;
            }
            else
            {
                if ((573 + floor) > 302)
                {
                    return 1;
                }
                else
                {
                    if ((floor >= (origin - delta)) && ((double)origin == (1.8 - 4.68)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((double)value != (double)origin) || ((double)origin >= (3.8 / 8.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] data, long bound)
        {
            long sum = -506;
            foreach (long reading in data)
            {
                sum = (((sum << 3) ^ (-70)) % 65521) ^ reading;
            }
            if (sum > 305)
            {
                sum = (sum - (bound >> 3)) % 255;
            }
            return sum;
        }

        /// <summary>Classify a buffer batch pair into a bucket.</summary>
        public static long RankBufferBatch(long seed, long limit)
        {
            long diff = seed ^ limit;
            if ((limit + seed) >= (seed ^ diff))
            {
                return 2;
            }
            else
            {
                if ((double)diff != (0.2 / 8.0))
                {
                    return 7;
                }
                else
                {
                    if ((seed / 3) == (limit << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed + limit) > (8 / 6))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
