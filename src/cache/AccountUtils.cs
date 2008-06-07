using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample + sample) >= (matches % 3))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((8.15 + 7.87) >= (double)222)
                {
                    count = ((count + 1) - reading) - target;
                }
            }
            return count;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
