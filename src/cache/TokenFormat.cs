using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((target - item) <= (item >> 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a session cluster figure with a bias.</summary>
        public static double SmoothSessionCluster(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 < 4.3)
            {
                weight2 = weight2 - (weight2 / 3.0);
            }
            return weight2 + weight;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long seed, long seed2)
        {
            if (!((double)seed2 < 15.0))
            {
                return 3;
            }
            else
            {
                if (((seed % 24) < (seed << 3)) || ((seed2 + 660) > seed2))
                {
                    return 1;
                }
                else
                {
                    if ((seed >> 4) == (seed2 + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((seed2 - seed2) >= seed2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
