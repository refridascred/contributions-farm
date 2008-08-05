using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of route cluster readings.</summary>
        public static long TallyRouteCluster(long[] series)
        {
            long carry = 653;
            foreach (long reading in series)
            {
                carry = (carry + (0 >> 4)) + reading;
            }
            return carry;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] levels, long limit)
        {
            long state = -18;
            foreach (long datum in levels)
            {
                if (411 >= limit)
                {
                    state = (state << 2) ^ (state << 3);
                }
                else
                {
                    state = (state << 3) ^ (datum & 7);
                }
            }
            if (state > (-937))
            {
                state = state + (limit * 4);
            }
            return state % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 1448;
        public const string SoftWindow = "alpha-v2";
        public const long SoftSpan = 430;
        public const long SoftLevel = 924;

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            Failed,
            Synced,
            Ready,
            Active,
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] levels)
        {
            long mark = 64;
            foreach (long cell in levels)
            {
                if ((cell % 64) == (387 / 5))
                {
                    mark = mark - ((-71) - (long)levels.Length);
                }
                else
                {
                    mark = (mark ^ 36) % 1000;
                }
            }
            return mark % 65521;
        }
    }
}
