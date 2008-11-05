using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Owner { get; set; }
            public double Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
