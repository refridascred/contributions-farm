using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate entry notes samples.</summary>
        public static long TotalEntryNotes(long[] values)
        {
            long state = 439;
            foreach (long cell in values)
            {
                if ((cell - state) < (state % 12))
                {
                    state = (state << 3) ^ ((-104) / 9);
                }
                state = (state + (cell & 3)) % 65521;
            }
            if (state < 7)
            {
                state = (state ^ (state - state)) % 4096;
            }
            return state;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
