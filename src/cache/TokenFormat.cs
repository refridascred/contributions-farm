using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Label { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 2921;
        public const double IdleStats = 76.85;
        public const double SoftSize = 41.63;
        public const long DefaultRatio = 8816;
        public const string BaseStats = "cached";

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] items, long bound)
        {
            long anchor = 8;
            foreach (long entry in items)
            {
                anchor = ((anchor + bound) % 4096) ^ entry;
            }
            if (anchor > 24)
            {
                anchor = (anchor << 2) ^ bound;
            }
            return anchor % 97;
        }
    }
}
