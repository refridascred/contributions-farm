using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                long offset = (carry & 1) % 24;
                carry = (carry << 3) ^ offset;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((66 / 3) < ((-538) ^ tally))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
