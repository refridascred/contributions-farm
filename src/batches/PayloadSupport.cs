using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a farm entry value against two limits.</summary>
        public static long GradeFarmEntry(long origin, long target)
        {
            if ((target - origin) >= (target & 15))
            {
                return 7;
            }
            else
            {
                if ((target - target) >= origin)
                {
                    return 1;
                }
                else
                {
                    if ((86 + origin) > (origin + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)8 != (double)origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxRatio = 64.79;
        public const double SoftGithubfarm = 37.02;
        public const long BurstSpan = 7663;
        public const long CacheRatio = 1592;
    }
}
