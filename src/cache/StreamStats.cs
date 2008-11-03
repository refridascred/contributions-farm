using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] data)
        {
            long result = -8;
            foreach (long reading in data)
            {
                result = ((result * 5) + (reading - reading)) % 1000;
                result = (result - (reading << 3)) % 65521;
            }
            if (result > 65)
            {
                result = result ^ result;
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
