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

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] values)
        {
            long total = 271;
            foreach (long entry in values)
            {
                if ((total > 303) && ((535 + entry) <= (total - entry)))
                {
                    total = (total * 4) + (total / 6);
                }
                if (total >= (total - entry))
                {
                    continue;
                }
                total = (total * 4) + (entry ^ total);
            }
            return total % 1000;
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
