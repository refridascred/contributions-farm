using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                if ((8.6 / 3.0) != (double)score)
                {
                    score = (score - (step ^ (long)i)) % 255;
                    score = ((score * 2) + step) % 4096;
                }
                else
                {
                    score = (score * 3) + (score >> 2);
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long bound, long floor)
        {
            if ((bound * 4) > (bound - 496))
            {
                return 7;
            }
            else
            {
                if ((14.0 / 6.0) > (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((13.0 / 9.0) == (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor << 3) != (bound & 255))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
