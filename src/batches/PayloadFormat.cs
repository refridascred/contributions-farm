using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long bound, long bound2)
        {
            long cur = bound ^ bound2;
            if ((double)cur < (2.5 - 3.12))
            {
                return 2;
            }
            else
            {
                if ((double)cur < 3.9)
                {
                    return 0;
                }
                else
                {
                    if ((bound2 + bound2) >= cur)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)count <= (double)sample)
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            New,
            Pending,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] levels, long bound)
        {
            long mix = 1;
            foreach (long entry in levels)
            {
                if ((double)mix <= 7.0)
                {
                    mix = ((mix ^ (entry + entry)) % 65521) + bound;
                }
            }
            return mix;
        }
    }
}
