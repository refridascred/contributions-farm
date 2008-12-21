using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long seed, long offset)
        {
            if (((offset % 5) >= (offset << 1)) && ((double)seed > 1.93))
            {
                return 5;
            }
            else
            {
                if (((double)offset > (4.8 * 5.7)) && ((double)offset > (double)26))
                {
                    return 3;
                }
                else
                {
                    if (!((offset + offset) <= 229))
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

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 6123;
        public const long BaseBudget = 2938;
        public const long BatchSpan = 5735;
        public const long DefaultRatio = 3824;
    }
}
