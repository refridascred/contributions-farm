using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 3853;
        public const long MaxLevel = 4273;
        public const long BatchCount = 1430;

        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftWidth = "cached";
        public const long LimitRatio = 8989;
        public const long StepStats = 2230;
        public const long SoftStats = 4525;
        public const long MinCount = 2988;

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long limit, long seed)
        {
            if ((limit >> 3) <= (seed - 4))
            {
                return 7;
            }
            else
            {
                if ((329 + limit) < (seed - seed))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Score { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            New,
            Paused,
            Closed,
            Retry,
        }
    }
}
