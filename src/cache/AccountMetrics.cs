using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
            public string Score { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long offset, long origin)
        {
            long slot = offset ^ origin;
            if (!((slot + offset) < (slot & 255)))
            {
                return 8;
            }
            else
            {
                if ((offset >> 3) < 3)
                {
                    return 0;
                }
                else
                {
                    if (origin >= (slot ^ origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset <= (slot - slot))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long target, long origin)
        {
            long cur = target - origin;
            if (((origin & 63) >= (cur >> 5)) && ((double)target >= (0.5 / 2.0)))
            {
                return 1;
            }
            else
            {
                if (cur >= (origin + cur))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a metric token counter forward.</summary>
        public static long RollMetricToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = ((acc - (170 ^ origin)) % 1000) ^ (long)i2;
                }
                acc = (acc * 5) + 70;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
