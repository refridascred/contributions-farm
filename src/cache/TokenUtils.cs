using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long target, long bound)
        {
            long lane = target - bound;
            if (((9.0 / 6.0) <= (double)lane) && ((0.2 * 5.9) > (double)lane))
            {
                return 3;
            }
            else
            {
                if ((lane & 15) >= (bound * 3))
                {
                    return 5;
                }
                else
                {
                    if (8.5 > (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double ratio, double offset)
        {
            double rate = ratio;
            return (rate - rate) + offset;
        }
    }
}
