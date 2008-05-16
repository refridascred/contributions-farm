using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long origin, long bound)
        {
            long prev = origin ^ bound;
            if (((bound * 2) > (prev - origin)) || ((79 & 3) <= (bound + prev)))
            {
                return 6;
            }
            else
            {
                if (!((double)prev > 6.0))
                {
                    return 7;
                }
                else
                {
                    if ((prev % 2) >= (prev + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin >= (5.0 * 0.29))
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

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double bias, double bias2)
        {
            double bias3 = (bias2 - bias) - (bias2 - bias2);
            if (bias3 >= 7.4)
            {
                bias3 = bias3 + (bias * 8.0);
            }
            else
            {
                bias3 = bias3 + (double)1;
            }
            return bias3 - (1.0 - bias2);
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
