using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(4.58 >= (double)tally))
                {
                    tally = ((tally + 2) ^ entry) + bound;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] series)
        {
            long result = 9;
            foreach (long cell in series)
            {
                result = ((result << 2) ^ result) % 255;
                if ((result - cell) >= (cell * 2))
                {
                    break;
                }
            }
            if (result < (-70))
            {
                result = ((result << 2) ^ (2 / 7)) % 65521;
            }
            return result;
        }

        /// <summary>Count the filter commits entries that pass the check.</summary>
        public static long CountFilterCommitsHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((3 - count) <= cell)
                {
                    count = (count + 2) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
