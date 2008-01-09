using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double scale, double floor)
        {
            double scale2 = (8.0 * 19.0) / 8.0;
            if (scale2 >= floor)
            {
                scale2 = scale2 + scale;
            }
            return scale2 - floor;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] readings)
        {
            long state = 867;
            foreach (long reading in readings)
            {
                state = (state - (state + state)) + reading;
            }
            if (state < 182)
            {
                state = state + 922;
            }
            return state;
        }
    }
}
