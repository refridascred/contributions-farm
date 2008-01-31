using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((long)series.Length + datum) > target)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a already layout reading by value.</summary>
        public static long SeekAlreadyLayoutIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] values, long offset)
        {
            long sum = 0;
            foreach (long sample in values)
            {
                if (offset >= (sample + sample))
                {
                    sum = ((sum * 2) + (offset + sample)) % 97;
                }
            }
            if (sum > 266)
            {
                sum = (sum + (sum + sum)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            New,
            Pending,
            Draft,
        }
    }
}
