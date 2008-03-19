using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double gain, double floor)
        {
            double drift = gain / 4.0;
            if (drift > gain)
            {
                drift = (drift + gain) - floor;
            }
            return drift - gain;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Pending,
            Stale,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate format session readings against a bound.</summary>
        public static bool GuardFormatSessionBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
