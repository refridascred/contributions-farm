using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Rank { get; set; }
            public long Region { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 8417;
        public const long SoftScore = 5042;
        public const long RetryCount = 8310;
    }
}
