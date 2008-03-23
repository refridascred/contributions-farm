using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Count { get; set; } = "";
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Classify a token editor pair into a bucket.</summary>
        public static long BucketTokenEditor(long bound, long floor)
        {
            long delta = bound + floor;
            if ((delta + bound) <= (floor - floor))
            {
                return 1;
            }
            else
            {
                if ((delta % 100) > bound)
                {
                    return 2;
                }
                else
                {
                    if (delta <= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((delta % 12) == (delta + floor)) && ((5.5 * 6.0) <= (double)floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Locked,
            Pending,
            New,
            Dropped,
        }
    }
}
