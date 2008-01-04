using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long offset, long limit)
        {
            if (78 >= (offset / 9))
            {
                return 4;
            }
            else
            {
                if ((double)limit > 7.9)
                {
                    return 6;
                }
                else
                {
                    if ((7.2 - 6.0) >= (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next metric githubfarm value from a seed.</summary>
        public static long RollMetricGithubfarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                result = (result << 2) ^ ((-96) - result);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
