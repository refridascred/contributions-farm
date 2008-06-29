using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinWidth = 2966;
        public const double LimitCache = 71.19;
        public const long MaxCache = 8235;

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate farm format readings against a bound.</summary>
        public static bool GuardFarmFormatLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Done,
            New,
            Locked,
        }
    }
}
