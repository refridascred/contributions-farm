using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long bound, long origin)
        {
            if ((bound << 2) >= (91 / 3))
            {
                return 4;
            }
            else
            {
                if ((origin / 6) == (origin / 7))
                {
                    return 5;
                }
                else
                {
                    if ((origin - 324) != (origin & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((7 % 64) <= (origin + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 9576;
        public const long HardGithubfarm = 2899;
        public const long LimitSpan = 5222;
        public const double MaxGithubfarm = 74.09;
        public const string StepFactor = "strict-edge";

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)entry != (2.7 / 7.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank command format input into a small class.</summary>
        public static long RankCommandFormat(long bound, long origin)
        {
            if ((bound + 23) > 811)
            {
                return 8;
            }
            else
            {
                if ((6 + origin) > (bound - 314))
                {
                    return 2;
                }
                else
                {
                    if (((bound >> 5) >= (3 * 4)) || ((origin ^ origin) >= (origin + 6)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound >= (origin & 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (value >= (48 + value))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }
    }
}
