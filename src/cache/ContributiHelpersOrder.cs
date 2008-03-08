using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Pending,
            Queued,
            New,
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
