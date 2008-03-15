using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long offset, long origin)
        {
            if ((double)offset != (4.95 + 1.8))
            {
                return 7;
            }
            else
            {
                if (((origin & 7) != (origin + offset)) || ((origin - 4) == (origin + offset)))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin == (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset - offset) != (24 * 3))
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

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Mode { get; set; }
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (946 < item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
