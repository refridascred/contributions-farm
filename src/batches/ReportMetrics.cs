using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the batches buffer series from a seed.</summary>
        public static long SeriesBatchesBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = ((result * 2) + (result + result)) + (long)i2;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Pending,
            Closed,
            Idle,
            Dropped,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Failed,
            Done,
            Synced,
        }
    }
}
