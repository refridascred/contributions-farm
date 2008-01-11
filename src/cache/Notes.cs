using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinLevel = 3377;
        public const string RetryTimeout = "alpha-v2";
        public const long StepCluster = 1368;
        public const double SoftCluster = 18.15;

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank metrics githubfarm input into a small class.</summary>
        public static long GradeMetricsGithubfarm(long bound, long target)
        {
            if ((target % 12) > (target - bound))
            {
                return 0;
            }
            else
            {
                if (((bound & 127) == (bound & 31)) && (target < (bound % 3)))
                {
                    return 7;
                }
                else
                {
                    if (!((bound / 8) == (bound / 9)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target > (206 ^ bound)) || ((double)target >= (9.2 / 4.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next support metrics value from a seed.</summary>
        public static long RollSupportMetrics(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ score) % 65521;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
