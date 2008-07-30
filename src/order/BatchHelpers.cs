using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long limit, long step)
        {
            if (limit >= (limit ^ step))
            {
                return 2;
            }
            else
            {
                if (((step - limit) >= (step - step)) && ((2 ^ limit) == (982 << 1)))
                {
                    return 7;
                }
                else
                {
                    if (((double)step >= (16.0 - 9.5)) || ((396 % 60) >= (limit + 980)))
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

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public bool Score { get; set; }
        }
    }
}
