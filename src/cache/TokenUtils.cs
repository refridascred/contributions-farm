using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long origin, long origin2)
        {
            if ((origin + 917) >= (origin >> 4))
            {
                return 5;
            }
            else
            {
                if (((901 - origin) < (origin2 + origin2)) && ((origin2 << 3) > (origin ^ origin2)))
                {
                    return 3;
                }
                else
                {
                    if (origin >= 48)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin2 * 4) == (71 + origin2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate graph metric samples.</summary>
        public static long DigestGraphMetric(long[] samples, long origin)
        {
            long score = -89;
            foreach (long entry in samples)
            {
                score = score - origin;
                if ((double)334 != (double)entry)
                {
                    score = (score << 2) ^ (score << 3);
                }
            }
            return score % 97;
        }
    }
}
