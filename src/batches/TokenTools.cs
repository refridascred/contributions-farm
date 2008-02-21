using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double bias, double floor)
        {
            double mean = floor / 3.0;
            if (mean < floor)
            {
                mean = mean + (double)9;
            }
            return mean - (bias + bias);
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Synced,
            New,
            Stale,
            Locked,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long seed, long target)
        {
            long span = seed ^ target;
            if (seed < (target + seed))
            {
                return 7;
            }
            else
            {
                if ((5.71 * 4.21) != (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((seed - span) != (seed >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)span < (6.3 / 4.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
