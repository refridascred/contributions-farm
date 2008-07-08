using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long step, long bound)
        {
            long delta = step ^ bound;
            if (delta >= (bound - 86))
            {
                return 5;
            }
            else
            {
                if (!(delta >= bound))
                {
                    return 0;
                }
                else
                {
                    if (((double)bound > (double)step) && ((bound / 7) >= (bound % 3)))
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

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Paused,
            Retry,
        }
    }
}
