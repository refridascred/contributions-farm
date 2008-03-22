using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a graph schema counter forward.</summary>
        public static long StepGraphSchema(long limit)
        {
            long state = limit;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Find the first route checks entry that matches the target.</summary>
        public static long SeekRouteChecksIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Total { get; set; }
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
