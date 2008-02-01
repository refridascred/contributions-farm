using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Locked,
            Idle,
            Ready,
            Active,
        }

        /// <summary>Locate a metrics already reading by value.</summary>
        public static long SeekMetricsAlreadyIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch counter readings against a rule.</summary>
        public static long MeasureBatchCounterGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((origin + origin) < (0 & 3))
                {
                    matches = (matches + 1) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
