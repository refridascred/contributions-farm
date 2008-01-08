using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((double)value != (20.0 + 6.9)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up support schema samples.</summary>
        public static long CompareSupportSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
