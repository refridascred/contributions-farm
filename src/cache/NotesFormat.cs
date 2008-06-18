using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next batches payload value.</summary>
        public static double ScaleBatchesPayload(double weight, double offset)
        {
            double rate = (weight / 8.0) * 6.0;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate - rate) - (double)(long)i) + offset;
            }
            return rate - (rate / 4.0);
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Synced,
            New,
            Pending,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                long edge = offset * 2;
                if ((edge >> 3) <= (offset + offset))
                {
                    anchor = ((anchor << 2) ^ ((long)i - anchor)) % 4096;
                }
                else
                {
                    anchor = ((anchor << 2) ^ offset) % 65521;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (anchor + (edge / 7)) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
