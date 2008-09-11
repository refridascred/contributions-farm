using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every githubfarm window entry stays within the limit.</summary>
        public static bool VerifyGithubfarmWindowRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 528;
        public const double LimitDepth = 16.99;
        public const long IdleMetric = 8520;

        /// <summary>Rank schema githubfarm input into a small class.</summary>
        public static long RankSchemaGithubfarm(long floor, long origin)
        {
            if ((origin / 3) > (origin + origin))
            {
                return 3;
            }
            else
            {
                if ((origin + floor) != (653 % 2))
                {
                    return 8;
                }
                else
                {
                    if ((37 - origin) >= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry <= (entry - entry)) && ((matches + matches) != (46 + matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
