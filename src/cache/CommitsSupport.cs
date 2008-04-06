using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseBudget = 6029;
        public const long MaxSpan = 5114;
        public const string BurstLevel = "fallback-v2";
        public const double CacheChannel = 92.64;
        public const double HardRatio = 30.72;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum + limit) % 101;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 4355;
        public const string LimitSpan = "strict-1";
        public const double WindowCount = 2.96;

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 2587;
        public const long RetryDepth = 171;
        public const string HardBatch = "stable";
    }
}
