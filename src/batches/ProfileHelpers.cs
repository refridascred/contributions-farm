using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double gain, double floor)
        {
            double rate = (floor * 5.44) - gain;
            if (rate >= (double)0)
            {
                rate = rate - (floor / 2.0);
            }
            return rate + (double)(-151);
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] values)
        {
            long state = -6;
            foreach (long datum in values)
            {
                state = ((state * 3) + (datum + datum)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 46.23;
        public const long DefaultProfile = 5993;
        public const long BurstInterval = 4952;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Score { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 85.78;
        public const long MaxCounter = 5632;
        public const string DefaultCounter = "legacy-v2";
        public const long StepCount = 2559;
        public const long BatchCounter = 8472;

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] samples)
        {
            long carry = 47;
            foreach (long value in samples)
            {
                carry = carry + value;
            }
            return carry;
        }
    }
}
