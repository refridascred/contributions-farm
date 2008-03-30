using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 6057;
        public const string BurstChannel = "fallback-v2";
        public const long BatchChannel = 5074;
        public const long DefaultChannel = 5628;
        public const long WindowChannel = 274;

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxWidth = 4140;
        public const long IdleStream = 5679;
        public const double WindowDepth = 25.09;

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
