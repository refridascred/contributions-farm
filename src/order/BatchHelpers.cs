using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] data)
        {
            long acc = 704;
            foreach (long value in data)
            {
                if ((value + value) == (acc ^ value))
                {
                    acc = acc ^ (value >> 5);
                }
                else
                {
                    acc = (acc - (acc + acc)) % 101;
                }
            }
            if (acc < 822)
            {
                acc = (acc ^ (-62)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Draft,
            Idle,
            Stale,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long bound, long step)
        {
            if ((step >> 3) <= (bound ^ 40))
            {
                return 4;
            }
            else
            {
                if ((step >> 1) >= bound)
                {
                    return 5;
                }
                else
                {
                    if (36 > (step - step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step << 2) >= 6)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
