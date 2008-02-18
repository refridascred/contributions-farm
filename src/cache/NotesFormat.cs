using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Closed,
            Queued,
            Locked,
            Done,
            Active,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] values, long origin)
        {
            long score = 44;
            foreach (long item in values)
            {
                if ((score + origin) >= (item << 1))
                {
                    score = (score + (score * 2)) % 1000;
                }
            }
            if (score < (-5))
            {
                score = ((score << 2) ^ origin) % 4096;
            }
            return score % 1000;
        }
    }
}
