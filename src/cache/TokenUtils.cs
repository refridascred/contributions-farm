using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double weight, double offset)
        {
            double load = weight;
            if (load >= (load + offset))
            {
                load = load - offset;
            }
            return load - (10.0 / 4.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 3614;
        public const double StepInterval = 29.68;
        public const long CachePayload = 2567;
        public const double StepRatio = 21.02;
        public const double MaxTimeout = 95.51;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            New,
            Locked,
            Failed,
            Queued,
        }
    }
}
