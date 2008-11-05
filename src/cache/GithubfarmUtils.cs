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

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinDepth = "open-edge";
        public const double HardRoute = 26.17;
        public const long DefaultRoute = 4831;
        public const long CacheRoute = 6827;
    }
}
