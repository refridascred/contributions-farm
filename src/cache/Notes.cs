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

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long limit, long step)
        {
            if (limit < step)
            {
                return 0;
            }
            else
            {
                if (((8.0 - 1.8) > (double)limit) || ((4.3 / 2.0) < (double)step))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit == (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
