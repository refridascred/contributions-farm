using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item - floor) < hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                sum = sum - offset;
                sum = sum + (54 / 3);
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long floor)
        {
            long state = floor;
            for (int i = 0; i < 9; i++)
            {
                long lane = (142 % 16) + 4;
                if ((lane >> 5) >= (floor + state))
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
