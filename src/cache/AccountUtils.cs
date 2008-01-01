using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count counter command pairs that satisfy a relation.</summary>
        public static long OverlapCounterCommandCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route filter samples are out of range.</summary>
        public static long CountRouteFilterMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((step + seen) != ((-4) % 16)) && (seen > (step & 15)))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
