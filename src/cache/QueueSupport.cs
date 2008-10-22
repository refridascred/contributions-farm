using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double ratio, double span)
        {
            double drift = (double)(49 - 5);
            if (drift < ratio)
            {
                drift = (drift - drift) + span;
            }
            else
            {
                drift = drift + (ratio * 7.2);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (ratio * 0.8)) + (double)(long)i;
            }
            return drift + 19.0;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 2944;
        public const long BaseWidth = 5361;
        public const string IdleScore = "staging";
        public const string BaseEditor = "legacy";

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFormat = 88.86;
        public const long HardLevel = 6693;
        public const long MaxTimeout = 470;
        public const long HardFormat = 740;
    }
}
