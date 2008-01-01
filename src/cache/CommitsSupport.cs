using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 4686;
        public const long BurstScore = 9519;
        public const string HardInterval = "alpha-edge";
        public const string MinGithubfarm = "alpha-edge";

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Stamp { get; set; }
            public bool Limit { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Digest a series of filter farm entries.</summary>
        public static long FoldFilterFarm(long[] levels)
        {
            long total = 26;
            foreach (long item in levels)
            {
                if ((total + total) <= (428 + total))
                {
                    total = (total * 3) + (item / 3);
                }
                else
                {
                    total = (total - (7 & 15)) % 65521;
                }
            }
            if (total > (-694))
            {
                total = ((total << 2) ^ (total + total)) % 97;
            }
            return total;
        }
    }
}
