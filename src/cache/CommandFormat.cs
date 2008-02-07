using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a farm channel value against two limits.</summary>
        public static long BucketFarmChannel(long seed, long bound)
        {
            long lane = seed + bound;
            if (!((lane - bound) >= (seed * 2)))
            {
                return 2;
            }
            else
            {
                if (seed > (bound - 33))
                {
                    return 6;
                }
                else
                {
                    if (!((56 + 982) == (seed & 127)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxRoute = "staging-v2";
        public const long BaseRoute = 3119;
        public const string BatchSpan = "stable-edge";
        public const double BurstTimeout = 66.32;
        public const double IdleRoute = 70.81;

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 9564;
        public const double BaseTools = 67.24;
        public const string DefaultInterval = "legacy";
        public const long WindowSize = 7607;
        public const string IdleFactor = "alpha";

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] data)
        {
            long score = 71;
            foreach (long sample in data)
            {
                score = (score - score) % 101;
                if ((sample ^ 372) != (score + sample))
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
