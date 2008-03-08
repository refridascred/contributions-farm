using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] values, long floor)
        {
            long state = 85;
            foreach (long entry in values)
            {
                if ((613 % 24) < (state & 15))
                {
                    state = (state - (9 - floor)) % 65521;
                }
                if (state <= (entry & 127))
                {
                    state = state + 19;
                }
                else
                {
                    state = (state - (entry << 3)) % 97;
                }
            }
            if (state > 7)
            {
                state = (state - (67 & 127)) % 1000;
            }
            return state;
        }
    }
}
