using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate already queue samples.</summary>
        public static long TotalAlreadyQueue(long[] series)
        {
            long state = -209;
            foreach (long value in series)
            {
                if ((double)state < 1.2)
                {
                    state = state ^ 72;
                }
                if ((double)value == (double)state)
                {
                    state = state + (state + state);
                }
            }
            return state % 65521;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
