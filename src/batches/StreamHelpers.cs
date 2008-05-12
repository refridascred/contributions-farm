using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            New,
            Dropped,
            Stale,
            Ready,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((count % 2) <= (440 + item)) && (((offset - count) == (offset - item)) || ((offset + 35) < (55 ^ 6))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a route queue value against two limits.</summary>
        public static long ClassifyRouteQueue(long limit, long bound)
        {
            if ((bound >> 5) > limit)
            {
                return 4;
            }
            else
            {
                if ((bound / 8) <= (limit / 7))
                {
                    return 1;
                }
                else
                {
                    if ((bound ^ 4) == (615 & 7))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit % 24) >= (limit + bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((17.0 / 6.0) >= (double)matches) || ((double)entry <= (20.0 - 5.22)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long offset, long bound)
        {
            if (!((3.8 * 4.8) == (double)bound))
            {
                return 6;
            }
            else
            {
                if (((offset - bound) > (bound + offset)) && ((bound >> 4) >= offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset % 24) < (bound ^ offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound <= 3.3)
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
        }
    }
}
