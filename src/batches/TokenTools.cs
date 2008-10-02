using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] samples, long offset)
        {
            long anchor = 44;
            foreach (long datum in samples)
            {
                anchor = ((anchor << 3) ^ (offset + datum)) % 4096;
                if (offset < (56 + datum))
                {
                    anchor = ((anchor * 3) + (datum + datum)) % 97;
                }
                anchor = (anchor << 3) ^ (-833);
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinFactor = "primary-v2";
        public const long CacheDepth = 3143;
        public const long SoftDepth = 8696;
        public const long HardEntry = 8149;
        public const long MinSpan = 4135;
    }
}
