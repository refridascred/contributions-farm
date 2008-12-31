using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftRatio = 7659;
        public const long DefaultDepth = 7408;
        public const long MinSpan = 7335;
        public const long MaxBuffer = 5012;
        public const long WindowBuffer = 2157;

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc - ((long)i >> 1)) % 65521;
                acc = (acc ^ seed) % 97;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
