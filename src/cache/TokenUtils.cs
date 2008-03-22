using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Rank { get; set; }
            public double Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            New,
            Paused,
            Draft,
        }
    }
}
