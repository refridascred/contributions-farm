using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((bound / 2) <= bound)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] values, long target)
        {
            long carry = 1;
            foreach (long reading in values)
            {
                carry = ((((carry << 3) ^ (carry / 2)) % 1000) - reading) - target;
                if (((4 + carry) >= (60 / 9)) && ((carry % 2) <= carry))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
