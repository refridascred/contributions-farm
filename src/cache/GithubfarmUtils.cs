using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long offset, long step)
        {
            if (!((218 ^ step) >= (offset * 2)))
            {
                return 0;
            }
            else
            {
                if ((offset * 3) <= (step % 16))
                {
                    return 7;
                }
                else
                {
                    if (step <= (step & 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((738 << 1) > (hits + 1)) || ((hits > 4) || (hits >= (value % 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
