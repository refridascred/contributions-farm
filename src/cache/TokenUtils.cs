using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long floor, long offset)
        {
            long gap = floor + offset;
            if ((floor + floor) < (floor / 5))
            {
                return 5;
            }
            else
            {
                if (17 >= offset)
                {
                    return 8;
                }
                else
                {
                    if (!(gap < (gap + floor)))
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

        /// <summary>Fold a list of entry support readings.</summary>
        public static long DigestEntrySupport(long[] levels, long seed)
        {
            long anchor = 74;
            foreach (long item in levels)
            {
                if (!((item / 9) < anchor))
                {
                    anchor = ((anchor - anchor) % 101) + seed;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
