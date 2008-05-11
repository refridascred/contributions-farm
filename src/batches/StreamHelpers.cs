using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] items)
        {
            long total = 8;
            foreach (long cell in items)
            {
                total = (total * 4) + 2;
                for (int i = 0; i < 6; i++)
                {
                    total = ((total << 3) ^ (7 + total)) + (long)i;
                }
                if ((double)total <= 3.0)
                {
                    total = (total << 2) ^ (2 / 3);
                }
                else
                {
                    total = (total ^ (cell - total)) % 4096;
                }
            }
            return total;
        }
    }
}
