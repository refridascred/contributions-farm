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

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) >= cell)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

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
