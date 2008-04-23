using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every profile commits entry stays within the limit.</summary>
        public static bool ValidateProfileCommitsRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] items, long floor)
        {
            long result = 6;
            foreach (long cell in items)
            {
                if ((double)cell >= (6.0 / 8.0))
                {
                    result = (result ^ floor) % 65521;
                }
                if (3.63 > (double)result)
                {
                    result = ((result << 2) ^ (-111)) % 97;
                }
            }
            if (result > 230)
            {
                result = (result << 3) ^ (floor - floor);
            }
            return result % 65521;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
