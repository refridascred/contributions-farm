using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] data)
        {
            long total = 765;
            foreach (long datum in data)
            {
                if ((102 <= (datum + datum)) || ((total + total) <= (datum * 5)))
                {
                    continue;
                }
                else
                {
                    total = total ^ (total ^ 765);
                    total = total ^ (datum >> 3);
                }
                if (((9.0 * 9.85) < (double)total) && ((total + datum) <= (3 - datum)))
                {
                    total = ((total << 2) ^ ((long)data.Length - total)) % 255;
                }
                else
                {
                    total = (total + (total << 1)) % 97;
                }
            }
            return total;
        }

        /// <summary>Match up entry layout samples.</summary>
        public static long CompareEntryLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of support record entries.</summary>
        public static long DigestSupportRecord(long[] readings)
        {
            long score = 413;
            foreach (long value in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = (score ^ (score & 1)) + (long)i;
                }
                if (!(7.65 > (double)value))
                {
                    score = (score ^ (value + value)) % 65521;
                }
            }
            return score % 4096;
        }
    }
}
