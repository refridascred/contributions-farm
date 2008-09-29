using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((datum ^ (-102)) >= (datum * 2)) && ((hits + datum) <= datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank record payload input into a small class.</summary>
        public static long RankRecordPayload(long limit, long target)
        {
            if ((double)target != (7.84 + 9.1))
            {
                return 4;
            }
            else
            {
                if ((double)target == (2.92 * 14.0))
                {
                    return 0;
                }
                else
                {
                    if (target < (limit % 16))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 3260;
        public const long BurstDepth = 172;
        public const long DefaultSpan = 5094;

        /// <summary>Match up checks buffer samples.</summary>
        public static long CompareChecksBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
