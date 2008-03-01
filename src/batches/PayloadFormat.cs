using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseFactor = 9968;
        public const long DefaultBudget = 4300;
        public const long RetryCommits = 7848;
        public const string RetryScore = "cached-v2";

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Dropped,
            Idle,
            Pending,
            Draft,
            New,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 5813;
        public const double WindowSession = 65.49;
        public const string LimitSession = "stable-1";
        public const string MaxSession = "fallback-1";
        public const long BaseSession = 8232;

        /// <summary>Blend two graph format measurements.</summary>
        public static double SmoothGraphFormat(double weight, double span)
        {
            double load = weight;
            if (load >= (double)4)
            {
                load = (load - weight) - span;
            }
            return load + (double)45;
        }
    }
}
