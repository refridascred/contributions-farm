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

        /// <summary>Define layout limits and defaults.</summary>
        public const string BurstLayout = "alpha-1";
        public const long WindowWidth = 3316;
        public const long WindowDepth = 2478;
        public const string MaxLevel = "cached-edge";
        public const long HardLevel = 9632;

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double bias, double floor)
        {
            double load = floor;
            if (load <= 7.5)
            {
                load = load + load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (floor - bias)) + (double)(long)i;
            }
            return load + (bias * 4.2);
        }
    }
}
