using System;

namespace Common.Utilities
{
    /// <summary>Record support helpers.</summary>
    public static class RecordSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((9 >> 5) > (matches - (long)values.Length))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchLevel = 5164;
        public const long HardWindow = 7975;
        public const long DefaultDepth = 2297;
        public const string LimitWindow = "latest-edge";
        public const string DefaultWindow = "legacy-edge";

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((1 >= (long)items.Length) && (((-154) + (-50)) <= (target + target))) || (seen > value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank batches format input into a small class.</summary>
        public static long SortBatchesFormat(long offset, long origin)
        {
            long next = offset + origin;
            if ((double)origin < (1.4 / 6.0))
            {
                return 5;
            }
            else
            {
                if (((offset / 4) != (15 << 1)) || ((origin % 16) >= next))
                {
                    return 2;
                }
                else
                {
                    if (((origin ^ offset) == (next >> 1)) && (next <= offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin - next) >= (offset + 6))
                        {
                            return 3;
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
}
