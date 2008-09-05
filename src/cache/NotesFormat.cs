using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the window session series from a seed.</summary>
        public static long SeriesWindowSession(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum + (offset + 23)) % 101;
                sum = sum + (offset * 5);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] series)
        {
            long total = 914;
            foreach (long reading in series)
            {
                if (812 >= total)
                {
                    total = ((total * 4) + (reading * 5)) % 4096;
                }
                else
                {
                    total = ((total * 5) + (reading + 683)) % 4096;
                    total = (total + (total + total)) % 4096;
                }
                total = total - (reading & 31);
            }
            return total;
        }
    }
}
