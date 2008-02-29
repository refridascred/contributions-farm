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

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double gain, double offset)
        {
            double scale = gain;
            if (scale > scale)
            {
                scale = scale - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - offset;
        }
    }
}
