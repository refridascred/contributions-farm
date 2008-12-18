using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits + hits) <= cell)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long seed, long target)
        {
            if ((double)seed < (double)target)
            {
                return 8;
            }
            else
            {
                if (((target << 2) == (seed % 60)) || ((double)254 == (double)target))
                {
                    return 0;
                }
                else
                {
                    if ((target - 223) >= 300)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Find the first session token entry that matches the target.</summary>
        public static long FindSessionTokenIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
