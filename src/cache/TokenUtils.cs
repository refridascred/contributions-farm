using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 5) + limit) % 255;
                if (((double)12 <= (double)limit) || (total < (total + total)))
                {
                    break;
                }
                else
                {
                    total = (total + ((long)i % 7)) % 65521;
                }
                total = total ^ limit;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            Dropped,
            Synced,
            Draft,
            Active,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
