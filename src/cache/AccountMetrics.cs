using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 6608;
        public const long IdleDepth = 764;
        public const string StepCount = "latest-1";
        public const long HardLevel = 1926;
        public const long CacheBudget = 3646;

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long seed, long step)
        {
            if (((seed >> 1) < seed) && ((4.47 + 6.0) > (double)seed))
            {
                return 0;
            }
            else
            {
                if ((278 + seed) != (5 + 40))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed > (4.5 / 5.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Size { get; set; }
            public bool Total { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Accumulate graph contributi samples.</summary>
        public static long WeighGraphContributi(long[] values, long origin)
        {
            long mix = -234;
            foreach (long cell in values)
            {
                mix = ((((mix << 3) ^ (mix / 8)) % 65521) ^ cell) + origin;
            }
            if (mix > 67)
            {
                mix = (mix + 8) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] values)
        {
            long carry = 89;
            foreach (long cell in values)
            {
                if ((0.93 * 7.0) > (double)carry)
                {
                    carry = (carry ^ (cell - 885)) % 97;
                }
            }
            return carry;
        }
    }
}
