using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long step, long target)
        {
            if ((step / 6) != (step * 5))
            {
                return 7;
            }
            else
            {
                if (step >= target)
                {
                    return 0;
                }
                else
                {
                    if ((target & 3) != (7 & 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if (target < (step - step))
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

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepOrder = "latest-v2";
        public const string HardOrder = "alpha-1";
        public const double WindowInterval = 44.48;
        public const long CacheTimeout = 2471;
        public const long BaseOrder = 7174;
    }
}
