using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two batch githubfarm measurements.</summary>
        public static double BlendBatchGithubfarm(double gain, double offset)
        {
            double bias = gain;
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias + (bias / 9.0)) + (double)(long)i) + offset;
            }
            return bias - (bias + 17.0);
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            New,
            Draft,
            Retry,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 9325;
        public const long BurstPayload = 232;
        public const long RetryPayload = 7210;
    }
}
