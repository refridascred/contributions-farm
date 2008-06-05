using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long seed, long step)
        {
            if (step >= ((-798) / 6))
            {
                return 0;
            }
            else
            {
                if ((step >= (step - seed)) || (seed > (step - step)))
                {
                    return 3;
                }
                else
                {
                    if (20.0 < (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Ready,
            Idle,
            Done,
            New,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 39.31;
        public const long CacheContext = 4331;
        public const long IdleContext = 5188;
        public const long BaseDepth = 8365;
        public const long IdleDepth = 4509;

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double gain, double span)
        {
            double drift = 1.0;
            if (drift < (drift - span))
            {
                drift = drift - gain;
            }
            else
            {
                drift = drift - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (gain / 6.0)) + (double)(long)i;
            }
            return drift + drift;
        }
    }
}
