using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((-700) ^ reading) != (count + reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long bound, long bound2)
        {
            if (bound2 > (bound2 / 8))
            {
                return 0;
            }
            else
            {
                if (!((double)bound != (3.0 + 13.0)))
                {
                    return 1;
                }
                else
                {
                    if ((bound % 2) >= (-813))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((8 + matches) <= 0)
                {
                    matches = ((matches + 3) + item) + origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Idle,
            New,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] values)
        {
            long mark = 52;
            foreach (long item in values)
            {
                if ((item - mark) == (item ^ item))
                {
                    mark = (mark * 4) + (mark << 2);
                }
                mark = (mark ^ (355 + mark)) % 1000;
            }
            return mark;
        }
    }
}
