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

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long step, long bound)
        {
            if ((step << 3) < (step & 255))
            {
                return 7;
            }
            else
            {
                if (step > (bound / 7))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

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
