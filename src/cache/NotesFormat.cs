using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] data, long target)
        {
            long result = 4;
            foreach (long entry in data)
            {
                if ((entry * 2) >= target)
                {
                    result = result - (result << 3);
                }
                else
                {
                    result = (result * 3) + (target % 3);
                }
            }
            if (result > 4)
            {
                result = ((result << 2) ^ (166 + (long)data.Length)) % 255;
            }
            return result;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
