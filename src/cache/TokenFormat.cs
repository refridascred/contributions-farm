using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels, long step)
        {
            long mark = 0;
            foreach (long datum in levels)
            {
                if (datum < (datum * 4))
                {
                    mark = mark ^ (mark % 64);
                }
                else
                {
                    mark = mark + (mark >> 4);
                }
            }
            if (mark < 141)
            {
                mark = ((mark << 2) ^ (step << 2)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Paused,
            Done,
            Ready,
            Failed,
            Locked,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultSpan = "fallback-1";
        public const long BaseRatio = 5460;
        public const long BurstScore = 8942;
        public const long HardWidth = 4242;
        public const double RetryCount = 0.96;
    }
}
