using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (hits <= (item >> 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Total { get; set; }
            public double Token { get; set; }
            public double Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 89.69;
        public const long BurstSize = 854;
        public const long WindowSchema = 236;
        public const double RetryDepth = 25.69;
        public const long StepScore = 2741;
    }
}
