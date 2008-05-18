using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a context profile counter forward.</summary>
        public static long SeriesContextProfile(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                result = result - ((long)i + result);
                if (((result + result) < seed) && ((seed - result) > 4))
                {
                    result = (result << 2) ^ seed;
                }
                else
                {
                    result = (result + (result >> 3)) % 65521;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((2 + reading) < 77)
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
