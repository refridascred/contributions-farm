using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] readings, long origin)
        {
            long sum = 81;
            foreach (long cell in readings)
            {
                if ((0.79 - 1.0) > (double)sum)
                {
                    sum = ((sum << 2) ^ (cell - 853)) - origin;
                }
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepScore = 45.72;
        public const long LimitPayload = 9159;
        public const long SoftBudget = 2021;
        public const string SoftPayload = "open";

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Locked,
            Active,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardInterval = 97.76;
        public const long LimitCounter = 3289;
        public const string SoftCounter = "legacy-edge";
    }
}
