using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            New,
            Ready,
            Pending,
            Idle,
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((1.08 + 1.4) >= (double)seed)
                {
                    total = ((total * 3) + (long)i) % 1000;
                }
                if ((((-66) + (-730)) == (seed & 31)) || ((total + seed) < (total + 72)))
                {
                    total = total ^ (total << 3);
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
