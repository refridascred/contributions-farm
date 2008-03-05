using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Owner { get; set; }
            public bool Total { get; set; }
            public double Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count context metrics pairs that satisfy a relation.</summary>
        public static long PairContextMetricsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long target, long step)
        {
            if ((double)step <= (double)target)
            {
                return 7;
            }
            else
            {
                if (((-21) < (24 + target)) || (step >= (target >> 1)))
                {
                    return 2;
                }
                else
                {
                    if ((step >> 1) < (step - target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((511 * 4) > (target + step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long offset, long floor)
        {
            long offset2 = offset ^ floor;
            if ((4.9 + 3.7) <= (2.94 / 9.0))
            {
                return 0;
            }
            else
            {
                if (((offset - 85) > 3) && (offset2 > (659 & 255)))
                {
                    return 4;
                }
                else
                {
                    if ((offset - floor) < (floor % 12))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(floor >= (offset2 % 10)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long floor, long step)
        {
            long cur = floor + step;
            if (!((step ^ step) == (cur / 4)))
            {
                return 7;
            }
            else
            {
                if ((0.58 - 4.56) <= (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (floor <= (8 + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor <= (2.96 / 5.0))
                        {
                            return 0;
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
}
