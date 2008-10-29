using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] values, long offset)
        {
            long sum = 6;
            foreach (long sample in values)
            {
                if (!((9 ^ 387) >= sum))
                {
                    sum = ((sum ^ offset) % 65521) ^ sample;
                }
            }
            return sum % 65521;
        }

        /// <summary>Count the schema format entries that pass the check.</summary>
        public static long CountSchemaFormatOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading - reading) < (reading * 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] series)
        {
            long state = 6;
            foreach (long item in series)
            {
                if ((3.8 >= (double)state) && (state <= (state + item)))
                {
                    continue;
                }
                if (20 <= (state / 2))
                {
                    state = ((state << 3) ^ (state - 6)) % 97;
                }
            }
            return state;
        }
    }
}
