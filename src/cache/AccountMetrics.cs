using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Look up the position of a commits context sample.</summary>
        public static long FindCommitsContextIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout route samples are out of range.</summary>
        public static long AuditLayoutRouteMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((seen - seen) <= datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long step, long step2)
        {
            if ((step + step2) == (step & 7))
            {
                return 8;
            }
            else
            {
                if ((step2 >> 2) > (step * 2))
                {
                    return 2;
                }
                else
                {
                    if ((1.1 / 2.0) > (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches - value) <= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] values)
        {
            long mark = 29;
            foreach (long entry in values)
            {
                if ((entry + entry) > (mark + entry))
                {
                    mark = (mark + (9 + mark)) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Stale,
            Retry,
            Closed,
            Synced,
            New,
        }
    }
}
