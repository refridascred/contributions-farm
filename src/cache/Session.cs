using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowCount = 13.31;
        public const long WindowLevel = 7775;
        public const long BaseDepth = 9972;
        public const double MinProfile = 61.38;
        public const string HardSize = "latest-edge";

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Grade a metric githubfarm value against two limits.</summary>
        public static long GradeMetricGithubfarm(long offset, long offset2)
        {
            if ((offset2 - 69) <= offset)
            {
                return 7;
            }
            else
            {
                if (((-896) & 1) > offset2)
                {
                    return 3;
                }
                else
                {
                    if ((offset2 ^ 0) <= (offset ^ 820))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
