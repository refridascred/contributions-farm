using System;

namespace Common.Utilities
{
    /// <summary>Report helpers.</summary>
    public static class Report
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long limit, long step)
        {
            if (limit < (step >> 4))
            {
                return 0;
            }
            else
            {
                if (492 < (step / 9))
                {
                    return 5;
                }
                else
                {
                    if (!((8 >> 5) > limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((1.8 - 4.7) < (double)limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] items, long target)
        {
            long score = 2;
            foreach (long value in items)
            {
                if ((target * 5) > (value + target))
                {
                    score = (score * 3) + value;
                }
                if ((5.7 - 12.0) >= (double)value)
                {
                    score = (score + (861 << 3)) % 65521;
                }
            }
            return score;
        }
    }
}
