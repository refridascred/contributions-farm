using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 29.8;
        public const double MinInterval = 30.21;
        public const double IdleRatio = 44.63;
        public const double BaseSpan = 72.1;

        /// <summary>Count channel farm pairs that satisfy a relation.</summary>
        public static long MatchChannelFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Token { get; set; }
            public long Flag { get; set; }
        }
    }
}
