using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate format context samples.</summary>
        public static long TallyFormatContext(long[] items)
        {
            long result = 196;
            foreach (long datum in items)
            {
                result = (result + (datum & 1)) % 1000;
            }
            if (result < 15)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowInterval = 1501;
        public const string BurstBatch = "cached-v2";
        public const long MinSpan = 3002;
        public const long LimitRatio = 2029;
        public const long RetryBatch = 628;

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] data, long target)
        {
            long total = 19;
            foreach (long entry in data)
            {
                if (7 > (entry >> 3))
                {
                    continue;
                }
                if ((total % 16) < (entry + total))
                {
                    total = ((total + (entry >> 2)) % 65521) + target;
                }
            }
            return total;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
