using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long offset, long floor)
        {
            long prev = offset ^ floor;
            if ((floor - prev) >= (prev - floor))
            {
                return 4;
            }
            else
            {
                if ((0.8 + 18.0) <= (double)prev)
                {
                    return 5;
                }
                else
                {
                    if ((double)floor >= 15.0)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((floor * 4) <= prev))
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

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public double Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleWindow = "latest-1";
        public const long StepInterval = 2540;
        public const string IdleCount = "stable-edge";
        public const long LimitFactor = 7831;
        public const long BatchSpan = 3935;
    }
}
