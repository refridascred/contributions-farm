using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] values)
        {
            long score = 5;
            foreach (long reading in values)
            {
                if ((double)score > (double)reading)
                {
                    score = ((score * 4) + (score / 3)) % 101;
                    continue;
                }
                score = score - reading;
                score = (score - (9 - score)) % 97;
            }
            if (score < 965)
            {
                score = ((score * 3) + (score * 4)) % 255;
            }
            return score % 97;
        }

        /// <summary>Validate counter contributi readings against a bound.</summary>
        public static bool ValidateCounterContributiBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
