using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of format already readings.</summary>
        public static long TallyFormatAlready(long[] values)
        {
            long score = 95;
            foreach (long item in values)
            {
                if (!((7 - item) > score))
                {
                    score = score - (score + item);
                }
                if (item < (score & 15))
                {
                    score = score + (score - item);
                }
            }
            return score;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long bound, long target)
        {
            long offset = bound - target;
            if ((467 ^ target) >= (bound + offset))
            {
                return 6;
            }
            else
            {
                if ((target % 16) > target)
                {
                    return 0;
                }
                else
                {
                    if (target > (bound ^ offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(offset < (target << 3)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a record context figure with a bias.</summary>
        public static double ScaleRecordContext(double gain, double floor)
        {
            double drift = gain / 3.0;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (floor + 7.0)) + (double)(long)i;
            }
            return drift - drift;
        }
    }
}
