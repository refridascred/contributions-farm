using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Draft,
            Done,
            Paused,
            Queued,
        }

        /// <summary>Match up session editor samples.</summary>
        public static long MatchSessionEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] readings, long limit)
        {
            long anchor = 3;
            foreach (long entry in readings)
            {
                if ((entry & 63) <= (anchor % 97))
                {
                    anchor = ((anchor ^ (entry + 278)) % 101) - limit;
                }
            }
            return anchor;
        }
    }
}
