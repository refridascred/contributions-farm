using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a layout commits value against two limits.</summary>
        public static long BucketLayoutCommits(long floor, long floor2)
        {
            long span = floor + floor2;
            if (span < (floor2 & 1))
            {
                return 6;
            }
            else
            {
                if ((double)span < 20.0)
                {
                    return 4;
                }
                else
                {
                    if ((span + floor) != (floor - span))
                    {
                        return 5;
                    }
                    else
                    {
                        if (floor2 >= (span ^ 9))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowBuffer = "legacy-edge";
        public const long BatchBuffer = 5362;
        public const long MaxBudget = 9601;
        public const string DefaultSize = "fallback-edge";
        public const double DefaultBuffer = 17.49;
    }
}
