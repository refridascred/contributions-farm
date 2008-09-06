using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank batches route input into a small class.</summary>
        public static long ClassifyBatchesRoute(long seed, long seed2)
        {
            long delta = seed + seed2;
            if (!((seed2 + delta) < 8))
            {
                return 6;
            }
            else
            {
                if (!(seed2 <= (seed + delta)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 8737;
        public const double CacheAlready = 88.21;
        public const long MaxRatio = 2457;

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
