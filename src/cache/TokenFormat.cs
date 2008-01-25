using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((item / 7) <= 35))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long target, long offset)
        {
            if (offset >= target)
            {
                return 7;
            }
            else
            {
                if (!((double)7 == (double)target))
                {
                    return 5;
                }
                else
                {
                    if (!((offset + target) >= target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
