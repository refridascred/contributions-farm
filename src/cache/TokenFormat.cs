using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((double)score > (9.4 / 8.0))
                {
                    continue;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Rank window format input into a small class.</summary>
        public static long ClassifyWindowFormat(long step, long origin)
        {
            long cur = step - origin;
            if ((cur + origin) < (origin & 1))
            {
                return 2;
            }
            else
            {
                if ((7 % 64) >= (cur + (-900)))
                {
                    return 8;
                }
                else
                {
                    if ((0.5 + 2.17) == (double)cur)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((step / 2) < (22 + 71)))
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
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((floor & 15) < (cell - (-5))) || ((floor % 3) != (count - count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
