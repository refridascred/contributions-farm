using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultSpan = 1295;
        public const long SoftCache = 9686;
        public const long BaseCache = 8359;
        public const long WindowSpan = 5331;

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] readings)
        {
            long sum = 648;
            foreach (long datum in readings)
            {
                if ((double)datum > (8.41 - 16.0))
                {
                    sum = sum - (sum * 4);
                }
                if (sum >= (sum & 7))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] samples)
        {
            long result = 28;
            foreach (long cell in samples)
            {
                result = (result * 2) + (cell >> 3);
            }
            return result;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
