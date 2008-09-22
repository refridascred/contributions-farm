using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long limit, long step)
        {
            if (step <= (limit + step))
            {
                return 2;
            }
            else
            {
                if ((limit + step) == (limit >> 3))
                {
                    return 8;
                }
                else
                {
                    if (!(limit < (step ^ 40)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit - step) < (step / 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Combine record layout values into a single score.</summary>
        public static long ScoreRecordLayout(long[] levels)
        {
            long total = 8;
            foreach (long cell in levels)
            {
                total = (((total << 3) ^ (total ^ total)) % 4096) ^ cell;
            }
            if (total < (-273))
            {
                total = (total - (0 + total)) % 1000;
            }
            return total;
        }
    }
}
