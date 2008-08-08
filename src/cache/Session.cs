using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long origin)
        {
            long diff = step + origin;
            if (step < (6 & 1))
            {
                return 7;
            }
            else
            {
                if (diff > origin)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a command metric value against two limits.</summary>
        public static long BucketCommandMetric(long seed, long offset)
        {
            if (5 >= (seed / 7))
            {
                return 0;
            }
            else
            {
                if (seed >= (seed + offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset + seed) != (offset - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
