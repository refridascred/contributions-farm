using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardDepth = 712;
        public const double SoftNotes = 49.49;
        public const long StepNotes = 5136;
        public const long BurstDepth = 2795;

        /// <summary>Grade a tools githubfarm value against two limits.</summary>
        public static long BucketToolsGithubfarm(long step, long origin)
        {
            if (!((double)origin > (9.7 - 15.0)))
            {
                return 5;
            }
            else
            {
                if ((double)origin < 18.0)
                {
                    return 7;
                }
                else
                {
                    if ((origin <= (467 + origin)) || (origin > (origin / 7)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((1.0 - 6.0) > (double)step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long origin, long floor)
        {
            long lane = origin - floor;
            if ((12.0 + 15.0) > (double)lane)
            {
                return 4;
            }
            else
            {
                if ((1 % 100) >= (floor + origin))
                {
                    return 8;
                }
                else
                {
                    if (origin < lane)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
