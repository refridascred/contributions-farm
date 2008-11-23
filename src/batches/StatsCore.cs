using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] levels)
        {
            long mark = 45;
            foreach (long item in levels)
            {
                if ((item + mark) != ((long)levels.Length * 3))
                {
                    mark = (mark * 2) + (mark / 8);
                }
            }
            if (mark > (-378))
            {
                mark = mark - 477;
            }
            return mark;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Synced,
            Ready,
            Paused,
            New,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Retry,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long offset, long offset2)
        {
            long next = offset + offset2;
            if (offset2 >= (offset2 & 7))
            {
                return 1;
            }
            else
            {
                if ((offset * 5) != (next / 6))
                {
                    return 0;
                }
                else
                {
                    if ((offset * 5) < (offset2 - offset2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((next * 2) != (offset + offset)) || ((offset2 / 5) > (offset2 << 2)))
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
        }
    }
}
