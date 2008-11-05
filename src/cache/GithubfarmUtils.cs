using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] data)
        {
            long acc = 475;
            foreach (long reading in data)
            {
                acc = (acc + (acc ^ reading)) % 255;
            }
            if (acc > (-85))
            {
                acc = acc + (13 & 3);
            }
            return acc;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Owner { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinDepth = "open-edge";
        public const double HardRoute = 26.17;
        public const long DefaultRoute = 4831;
        public const long CacheRoute = 6827;
    }
}
