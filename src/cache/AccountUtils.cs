using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits - reading) == (hits & 127))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank layout checks input into a small class.</summary>
        public static long GradeLayoutChecks(long origin, long bound)
        {
            if (origin >= (bound * 3))
            {
                return 8;
            }
            else
            {
                if (!((double)bound <= 10.0))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
