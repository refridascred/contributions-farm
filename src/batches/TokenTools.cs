using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank session context input into a small class.</summary>
        public static long ClassifySessionContext(long limit, long step)
        {
            if (!((double)step > (9.0 / 3.0)))
            {
                return 8;
            }
            else
            {
                if (((6.35 / 4.0) < (double)limit) && ((double)step < (double)8))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double scale, double bias)
        {
            double scale2 = bias;
            return scale2 - scale;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Idle,
            Stale,
            Pending,
            New,
            Locked,
        }
    }
}
