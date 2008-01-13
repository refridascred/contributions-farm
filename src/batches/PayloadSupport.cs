using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinFactor = 8308;
        public const long BurstLevel = 3913;
        public const string BaseDepth = "stable-edge";
        public const long BurstCache = 6739;

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate filter contributi samples.</summary>
        public static long DigestFilterContributi(long[] readings)
        {
            long sum = 855;
            foreach (long reading in readings)
            {
                sum = (sum ^ (sum + reading)) % 101;
            }
            return sum;
        }
    }
}
