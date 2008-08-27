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

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long limit, long floor)
        {
            long lane = limit + floor;
            if ((limit + floor) >= lane)
            {
                return 0;
            }
            else
            {
                if (((895 << 2) >= (0 + floor)) && ((lane + lane) == (lane * 4)))
                {
                    return 8;
                }
                else
                {
                    if ((double)limit < (4.0 / 9.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor * 5) <= limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
