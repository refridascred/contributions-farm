using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((long)samples.Length % 2) > (-7))
                {
                    count = ((count + 1) + reading) + floor;
                }
            }
            return count;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Idle,
            Queued,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheBatches = "local-1";
        public const string CacheCount = "legacy-edge";
        public const long WindowBatches = 5634;
        public const long BurstBatches = 9288;
        public const long IdleBatches = 8332;
    }
}
