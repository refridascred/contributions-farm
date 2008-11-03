using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                result = ((result << 3) ^ (result - result)) % 4096;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Retry,
            Done,
            Stale,
            Queued,
        }

        /// <summary>Look up the position of a session payload sample.</summary>
        public static long SeekSessionPayloadIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }
    }
}
