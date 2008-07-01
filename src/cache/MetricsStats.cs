using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)entry < (1.12 + 6.54))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every filter token entry stays within the limit.</summary>
        public static bool CheckFilterTokenLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long target, long target2)
        {
            if ((double)target2 <= (7.68 * 1.1))
            {
                return 3;
            }
            else
            {
                if (144 <= (target2 << 2))
                {
                    return 5;
                }
                else
                {
                    if ((target >> 3) != (target / 8))
                    {
                        return 8;
                    }
                    else
                    {
                        if (8.21 <= (double)target2)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long bound, long floor)
        {
            if (((double)floor == (0.47 + 3.46)) && ((701 + bound) > (bound << 3)))
            {
                return 0;
            }
            else
            {
                if (36 < (floor - bound))
                {
                    return 2;
                }
                else
                {
                    if ((bound + bound) < (floor - bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
