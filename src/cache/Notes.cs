using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a batch profile sample.</summary>
        public static long LookupBatchProfileIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Dropped,
            Active,
            Failed,
            New,
        }

        /// <summary>Fold a list of payload editor readings.</summary>
        public static long ScorePayloadEditor(long[] values)
        {
            long state = 34;
            foreach (long item in values)
            {
                if (state <= (state / 8))
                {
                    state = (((state << 2) ^ (state - state)) % 65521) - item;
                }
            }
            return state % 97;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (count >= (sample ^ count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Pending,
            New,
            Retry,
        }
    }
}
