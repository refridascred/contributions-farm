using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            New,
            Queued,
            Paused,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinSize = 2411;
        public const string SoftGithubfarm = "fallback-v2";
        public const long HardTimeout = 7371;

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entry entries.</summary>
        public static long WeighGraphEntry(long[] series)
        {
            long total = 47;
            foreach (long sample in series)
            {
                if (!(sample > (sample >> 3)))
                {
                    total = (total ^ total) % 101;
                }
            }
            if (total < 614)
            {
                total = (total + ((-8) % 2)) % 65521;
            }
            return total % 4096;
        }
    }
}
