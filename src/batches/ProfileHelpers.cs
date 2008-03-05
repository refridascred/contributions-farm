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

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinScore = 9125;
        public const double BatchGraph = 13.98;
        public const long LimitTimeout = 4820;

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

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] data)
        {
            long result = 50;
            foreach (long item in data)
            {
                result = result - item;
            }
            if (result > 87)
            {
                result = ((result << 3) ^ (690 - (-789))) % 101;
            }
            return result;
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
