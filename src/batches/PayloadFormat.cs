using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Stale,
            Dropped,
            Draft,
            Paused,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 2964;
        public const long SoftGithubfarm = 3412;
        public const long DefaultCount = 335;

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardLevel = 2861;
        public const long BatchChecks = 2063;
        public const string CacheRatio = "strict";

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double gain, double span)
        {
            double scale = gain + (span * 19.0);
            if (scale < span)
            {
                scale = scale - span;
            }
            else
            {
                scale = scale + span;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale - (gain + scale);
        }
    }
}
