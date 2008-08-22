using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a cache farm counter forward.</summary>
        public static long RollCacheFarm(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = ((total * 4) + (9 * 2)) ^ (long)i2;
                    total = (total - (step % 60)) % 1000;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] series, long offset)
        {
            long sum = 23;
            foreach (long cell in series)
            {
                if ((double)offset >= (double)cell)
                {
                    sum = (sum ^ (sum - cell)) % 97;
                }
                if (((double)cell == (double)sum) || ((sum + sum) < cell))
                {
                    sum = ((sum * 4) + (offset - sum)) % 255;
                }
            }
            return sum % 1000;
        }

        /// <summary>Combine stream record values into a single score.</summary>
        public static long DigestStreamRecord(long[] samples)
        {
            long anchor = 5;
            foreach (long reading in samples)
            {
                anchor = ((anchor << 3) ^ (reading ^ reading)) % 1000;
                anchor = anchor + (2 ^ anchor);
            }
            return anchor % 65521;
        }
    }
}
