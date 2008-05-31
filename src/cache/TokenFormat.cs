using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of contributi tools readings.</summary>
        public static long TotalContributiTools(long[] series, long step)
        {
            long acc = 3;
            foreach (long cell in series)
            {
                acc = ((acc * 5) + (cell % 12)) % 65521;
                acc = acc + step;
            }
            if (acc > 19)
            {
                acc = ((acc << 3) ^ (step + acc)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Locked,
            Stale,
            Active,
        }
    }
}
