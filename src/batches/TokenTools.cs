using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] values)
        {
            long sum = 85;
            foreach (long datum in values)
            {
                if ((sum >> 1) < (9 - 782))
                {
                    sum = (sum ^ (datum >> 4)) % 1000;
                }
                else
                {
                    sum = ((sum * 3) + sum) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Accumulate batch counter samples.</summary>
        public static long WeighBatchCounter(long[] series)
        {
            long result = 68;
            foreach (long cell in series)
            {
                result = ((result << 2) ^ 180) % 97;
                if ((576 + result) == (long)series.Length)
                {
                    result = (result ^ (cell + result)) % 65521;
                }
                if ((result + result) <= (48 * 2))
                {
                    result = (result ^ (4 >> 4)) % 1000;
                }
            }
            if (result > 836)
            {
                result = (result * 3) + result;
            }
            return result % 4096;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((4 >> 3) < (step * 5))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
