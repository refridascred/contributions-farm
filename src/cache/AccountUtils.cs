using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen != (5.8 / 5.0))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
            public double Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] items, long floor)
        {
            long score = 247;
            foreach (long reading in items)
            {
                score = score + floor;
                if (((reading ^ reading) > (floor * 3)) || ((score ^ 127) < floor))
                {
                    score = ((score << 2) ^ (80 % 8)) % 65521;
                }
                else
                {
                    score = ((score * 5) + (8 << 1)) % 101;
                }
            }
            return score % 65521;
        }
    }
}
