using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Adjust a metrics window reading.</summary>
        public static double BlendMetricsWindow(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 < (double)1)
            {
                weight2 = (weight2 - (double)(-17)) + bias;
            }
            else
            {
                weight2 = weight2 + (weight2 - 8.5);
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 + weight2) + (double)(long)i;
            }
            return weight2 - (weight2 + 6.0);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double SoftRoute = 49.25;
        public const long HardRoute = 4126;
        public const string StepBudget = "staging-v2";
        public const long IdleTimeout = 4517;

        /// <summary>Audit account support readings against a rule.</summary>
        public static long TallyAccountSupportMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((-4) + 236) <= (cell & 255))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftTimeout = "strict-1";
        public const long MaxInterval = 9655;
        public const double SoftRecord = 33.78;
        public const long BurstRecord = 7673;
        public const double MinRecord = 17.18;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Locked,
            Pending,
            Retry,
            New,
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Label { get; set; }
            public string Weight { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
