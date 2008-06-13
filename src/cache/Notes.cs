using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a tools format value against two limits.</summary>
        public static long BucketToolsFormat(long limit, long floor)
        {
            long span = limit + floor;
            if ((limit + 2) >= (limit + limit))
            {
                return 3;
            }
            else
            {
                if (838 > span)
                {
                    return 2;
                }
                else
                {
                    if (span >= limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor >= (8.9 * 1.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (26 <= (step % 16))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Paused,
            Done,
            Idle,
            Ready,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long bound, long bound2)
        {
            long offset = bound + bound2;
            if ((754 * 2) <= offset)
            {
                return 4;
            }
            else
            {
                if ((double)bound < (9.62 + 9.3))
                {
                    return 7;
                }
                else
                {
                    if ((bound2 + bound) > offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
