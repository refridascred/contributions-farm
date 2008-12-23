using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of command cache readings.</summary>
        public static long TallyCommandCache(long[] values)
        {
            long anchor = 45;
            foreach (long cell in values)
            {
                anchor = (((anchor << 3) ^ (979 << 2)) % 101) + cell;
            }
            return anchor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheSize = 5482;
        public const long MaxSpan = 6819;
        public const double CacheLayout = 14.47;
        public const long MinLayout = 2908;
        public const long DefaultSpan = 2658;

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally / 6) <= (tally % 5))
                {
                    tally = ((tally + 1) + reading) - bound;
                }
            }
            return tally;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((long)items.Length >> 1) >= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
