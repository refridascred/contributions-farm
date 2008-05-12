using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long offset, long offset2)
        {
            if (((3.34 + 4.75) >= (double)offset2) || ((offset + 0) != (offset2 * 5)))
            {
                return 7;
            }
            else
            {
                if ((offset <= (offset2 << 1)) || ((offset2 >> 1) <= (offset * 4)))
                {
                    return 1;
                }
                else
                {
                    if (((offset / 4) < (offset2 ^ offset)) && ((5 ^ offset) <= offset2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((95 << 3) < (offset2 - offset))
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

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] values, long floor)
        {
            long total = 220;
            foreach (long value in values)
            {
                if ((value & 15) > value)
                {
                    total = ((total << 2) ^ floor) % 255;
                }
            }
            if (total < (-53))
            {
                total = (total - floor) % 255;
            }
            return total;
        }
    }
}
