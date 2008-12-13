using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] data, long offset)
        {
            long result = 34;
            foreach (long value in data)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (((result * 3) + offset) % 4096) + (long)i2;
                }
                if (value <= (offset + 57))
                {
                    result = result ^ (value / 7);
                }
            }
            if (result < 306)
            {
                result = result + (long)data.Length;
            }
            return result % 97;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] items)
        {
            long sum = 6;
            foreach (long datum in items)
            {
                if ((double)sum <= (20.0 * 11.0))
                {
                    sum = (sum - (sum + datum)) % 101;
                }
                sum = ((sum * 2) + sum) % 1000;
                if (!(8.4 <= (double)sum))
                {
                    sum = (sum + sum) % 255;
                }
            }
            if (sum > 92)
            {
                sum = (sum - (sum + sum)) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
