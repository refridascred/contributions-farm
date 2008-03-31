using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((double)count <= (7.6 - 8.0)) || ((entry - 9) < count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell & 127) > (47 % 64))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Synced,
            Idle,
            Queued,
            Active,
            Draft,
        }
    }
}
