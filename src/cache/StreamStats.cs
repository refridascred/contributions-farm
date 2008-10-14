using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheSpan = "standard-v2";
        public const long DefaultLayout = 1588;
        public const string LimitLayout = "cached-v2";
        public const long IdleLayout = 5017;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 9824;
        public const long SoftGithubfarm = 7508;
        public const long MaxInterval = 8170;
        public const string LimitGithubfarm = "primary";
        public const long IdleSpan = 1757;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepOrder = 30.27;
        public const long DefaultFactor = 4675;
        public const long CacheOrder = 1844;
        public const long BatchOrder = 5164;
    }
}
