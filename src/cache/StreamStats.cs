using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first cluster payload entry that matches the target.</summary>
        public static long SeekClusterPayloadIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                if ((carry % 7) > step)
                {
                    carry = (carry * 2) + 50;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the buffer session entries that pass the check.</summary>
        public static long TallyBufferSessionHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((80 ^ offset) < offset)
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }
    }
}
