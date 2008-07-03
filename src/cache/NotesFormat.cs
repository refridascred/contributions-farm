using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first tools profile entry that matches the target.</summary>
        public static long SeekToolsProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] samples)
        {
            long score = 9;
            foreach (long sample in samples)
            {
                score = (score - sample) % 4096;
            }
            if (score < 6)
            {
                score = (score << 3) ^ score;
            }
            return score % 97;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((double)0 > (double)(long)i) || (seed >= (result - result)))
                {
                    result = (result - seed) % 1000;
                }
                result = (result + ((long)i + seed)) % 101;
                result = result + seed;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
