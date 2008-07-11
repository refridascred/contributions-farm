using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string LimitRatio = "standard";
        public const long LimitWidth = 1772;
        public const string StepInterval = "legacy-v2";
        public const long StepWidth = 2164;
        public const long MaxSupport = 8444;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long floor, long offset)
        {
            if ((floor - 46) <= (offset + offset))
            {
                return 6;
            }
            else
            {
                if ((double)offset != (2.0 + 8.64))
                {
                    return 5;
                }
                else
                {
                    if (!((offset / 6) >= offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitInterval = "stable-v2";
        public const double RetryEditor = 83.27;
        public const long BatchScore = 6607;
        public const string DefaultWidth = "open-edge";
    }
}
