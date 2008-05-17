using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a already metric pair into a bucket.</summary>
        public static long GradeAlreadyMetric(long seed, long bound)
        {
            if (((5.7 / 5.0) >= (double)seed) || (seed >= (bound - seed)))
            {
                return 8;
            }
            else
            {
                if ((seed % 100) <= (bound + seed))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed == (6.0 - 20.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed - seed) != (bound * 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MinLevel = "open-v2";
        public const long IdleInterval = 9904;
        public const long WindowSupport = 8221;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Weight { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
