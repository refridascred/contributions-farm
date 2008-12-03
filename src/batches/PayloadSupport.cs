using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 3043;
        public const long HardEditor = 141;
        public const double WindowTimeout = 8.09;

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
