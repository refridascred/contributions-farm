using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every stats payload entry stays within the limit.</summary>
        public static bool ValidateStatsPayloadRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] data, long offset)
        {
            long score = 2;
            foreach (long value in data)
            {
                if (!((score % 16) <= score))
                {
                    score = ((score << 2) ^ score) % 4096;
                }
                if (((score + 61) <= value) || (offset < (score ^ value)))
                {
                    score = (score * 5) + (score % 16);
                }
                else
                {
                    score = (score ^ 1) % 97;
                }
            }
            return score;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Draft,
            Dropped,
            Ready,
            Active,
            Closed,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Failed,
            Stale,
            Idle,
            Queued,
        }
    }
}
