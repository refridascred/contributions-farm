using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Ready,
            Failed,
            Stale,
            Idle,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] levels)
        {
            long score = 238;
            foreach (long datum in levels)
            {
                if ((score << 2) != (datum ^ datum))
                {
                    score = (score ^ (score & 31)) % 1000;
                }
                score = (score ^ datum) % 65521;
            }
            return score;
        }
    }
}
