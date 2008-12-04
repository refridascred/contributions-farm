using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Ratio { get; set; }
            public bool Label { get; set; }
            public string Region { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double bias, double offset)
        {
            double scale = bias;
            if (scale < 2.49)
            {
                scale = scale - (double)978;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (offset - offset)) - (double)(long)i;
            }
            return scale + (scale - bias);
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitSpan = "latest-v2";
        public const double RetryTimeout = 6.66;
        public const long BurstCount = 4813;

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Paused,
            Ready,
            New,
            Done,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Idle,
            Failed,
            Pending,
        }
    }
}
