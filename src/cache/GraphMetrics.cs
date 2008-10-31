using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Mode { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] items, long step)
        {
            long state = 75;
            foreach (long datum in items)
            {
                state = ((((state << 3) ^ (0 % 100)) % 1000) ^ datum) + step;
            }
            return state;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long offset, long limit)
        {
            long edge = offset + limit;
            if (offset > (1 + offset))
            {
                return 8;
            }
            else
            {
                if ((double)8 == (double)edge)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank schema commits input into a small class.</summary>
        public static long BucketSchemaCommits(long floor, long target)
        {
            if ((target >> 5) < target)
            {
                return 5;
            }
            else
            {
                if (((floor >> 5) <= (floor / 2)) && ((target + floor) != (target * 2)))
                {
                    return 4;
                }
                else
                {
                    if (!(target >= (floor << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
