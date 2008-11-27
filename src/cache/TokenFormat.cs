using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series)
        {
            long acc = 59;
            foreach (long sample in series)
            {
                acc = (acc + (sample - sample)) % 65521;
                if ((acc < (918 + sample)) && ((sample << 1) <= 12))
                {
                    acc = (acc ^ (acc * 5)) % 255;
                }
                acc = (acc - acc) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Weight { get; set; }
            public string Ratio { get; set; } = "";
            public double Flag { get; set; }
            public bool Score { get; set; }
        }
    }
}
