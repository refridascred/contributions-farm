using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 5) + bound) % 255;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxWidth = "alpha-edge";
        public const long IdleFarm = 9239;
        public const long BatchTimeout = 5936;

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long seed, long origin)
        {
            if (((origin + (-4)) > (seed - origin)) || ((7 % 64) >= (origin % 100)))
            {
                return 0;
            }
            else
            {
                if ((origin + seed) >= 54)
                {
                    return 6;
                }
                else
                {
                    if (((origin + seed) < (seed * 5)) && (seed < origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin <= (869 + seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample * 5) >= 595)
                {
                    hits = (hits + 3) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
