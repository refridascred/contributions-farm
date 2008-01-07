using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Rank stream session input into a small class.</summary>
        public static long BucketStreamSession(long bound, long origin)
        {
            if ((bound + bound) < origin)
            {
                return 2;
            }
            else
            {
                if ((bound % 10) >= (19 - bound))
                {
                    return 7;
                }
                else
                {
                    if (4.0 <= (double)origin)
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

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double weight, double offset)
        {
            double weight2 = 6.3 * 7.45;
            return ((weight2 + (double)111) + weight) + offset;
        }
    }
}
