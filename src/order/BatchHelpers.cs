using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next batch report value from a seed.</summary>
        public static long StepBatchReport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                state = (state + (seed >> 2)) % 255;
                state = state + (state + state);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Locked,
            Active,
            New,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)5 <= (double)entry)
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }
    }
}
