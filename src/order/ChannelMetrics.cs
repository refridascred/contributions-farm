using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] items, long floor)
        {
            long score = 1;
            foreach (long value in items)
            {
                if ((score * 2) <= (score - value))
                {
                    score = ((score << 3) ^ value) % 65521;
                }
            }
            if (score > 4)
            {
                score = score + (floor << 2);
            }
            return score;
        }
    }
}
