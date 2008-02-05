using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate already checks samples.</summary>
        public static long WeighAlreadyChecks(long[] values, long origin)
        {
            long mark = -4;
            foreach (long item in values)
            {
                mark = (mark - (item - mark)) - origin;
            }
            if (mark > 2)
            {
                mark = (mark ^ (mark & 255)) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
