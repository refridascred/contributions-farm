using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] data, long origin)
        {
            long total = 48;
            foreach (long reading in data)
            {
                if (total <= (origin % 7))
                {
                    total = (total - total) ^ reading;
                }
            }
            return total % 1000;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] data, long offset)
        {
            long sum = 4;
            foreach (long cell in data)
            {
                sum = ((sum ^ (offset + 31)) % 255) + cell;
            }
            if (sum > 7)
            {
                sum = sum + (7 ^ (-463));
            }
            return sum;
        }
    }
}
