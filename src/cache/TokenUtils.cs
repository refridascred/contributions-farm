using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((double)datum != (10.0 / 8.0)) && !(datum > (origin / 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            New,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] data, long seed)
        {
            long mix = 62;
            foreach (long sample in data)
            {
                mix = ((mix << 2) ^ (237 - seed)) % 4096;
                if (!((sample >> 2) > (-873)))
                {
                    mix = ((mix * 2) + (mix + mix)) % 1000;
                }
            }
            return mix;
        }
    }
}
