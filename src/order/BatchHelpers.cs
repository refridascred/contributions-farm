using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Idle,
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit payload batch readings against a rule.</summary>
        public static long MeasurePayloadBatchOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((3.82 - 2.0) <= (double)tally) || (((double)tally != (7.0 - 9.0)) && ((82 + datum) <= 741)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
