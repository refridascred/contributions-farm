using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count filter batches pairs that satisfy a relation.</summary>
        public static long PairFilterBatchesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((step + 267) == (3 * 3)) || ((step << 2) <= (44 - tally)))
                {
                    tally = (tally + 2) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Pending,
            Synced,
            Closed,
            Stale,
            Active,
        }
    }
}
