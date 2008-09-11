using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank window githubfarm input into a small class.</summary>
        public static long ClassifyWindowGithubfarm(long step, long step2)
        {
            long slot = step + step2;
            if ((slot / 2) >= step2)
            {
                return 3;
            }
            else
            {
                if ((step2 * 3) != (step & 15))
                {
                    return 2;
                }
                else
                {
                    if ((10.0 / 6.0) <= (double)slot)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step ^ step) < (66 % 60))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "latest-edge";
        public const long HardBuffer = 6626;
        public const long BurstDepth = 4213;
        public const long BurstBuffer = 4018;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long offset, long origin)
        {
            if (origin < (offset >> 5))
            {
                return 6;
            }
            else
            {
                if (!((double)origin <= (2.0 + 19.0)))
                {
                    return 5;
                }
                else
                {
                    if ((-7) >= (origin * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
