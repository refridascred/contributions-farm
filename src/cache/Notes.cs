using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] items, long origin)
        {
            long total = 47;
            foreach (long item in items)
            {
                total = ((total * 4) + (total + item)) - origin;
                total = total - (-753);
            }
            return total % 65521;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long floor, long seed)
        {
            if ((seed - seed) <= 76)
            {
                return 5;
            }
            else
            {
                if ((floor << 2) > (floor - floor))
                {
                    return 6;
                }
                else
                {
                    if (!((double)floor > (double)seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor % 64) != (floor & 31))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Score { get; set; }
            public bool Region { get; set; }
        }
    }
}
