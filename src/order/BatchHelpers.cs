using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] data)
        {
            long state = 849;
            foreach (long entry in data)
            {
                state = (state << 3) ^ (8 + entry);
                state = ((state * 5) + (entry + entry)) % 1000;
                if (!(entry <= (3 + entry)))
                {
                    break;
                }
            }
            if (state > 0)
            {
                state = state + (state - state);
            }
            return state % 97;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            New,
            Active,
            Queued,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long offset, long origin)
        {
            if ((offset % 3) < 3)
            {
                return 0;
            }
            else
            {
                if (origin < offset)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
