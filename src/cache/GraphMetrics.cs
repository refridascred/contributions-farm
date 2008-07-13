using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepDepth = "legacy";
        public const double BatchWidth = 38.16;
        public const double IdleGithubfarm = 59.35;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftLevel = "strict-edge";
        public const double LimitTimeout = 85.43;
        public const long LimitFarm = 3382;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long origin, long step)
        {
            long span = origin ^ step;
            if (origin >= (-38))
            {
                return 0;
            }
            else
            {
                if ((step <= (origin % 3)) || ((double)span != (10.0 * 15.0)))
                {
                    return 5;
                }
                else
                {
                    if (3.0 > (double)span)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-18) < (span + origin)) || ((step + step) < step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((matches - item) <= (item ^ matches)) && ((item ^ 8) > 46))
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
