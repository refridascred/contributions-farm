using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Draft,
            Active,
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MinFactor = 68.34;
        public const long DefaultRatio = 813;
        public const string MinSpan = "cached";

        /// <summary>Fold a list of graph payload readings.</summary>
        public static long DigestGraphPayload(long[] samples)
        {
            long acc = 64;
            foreach (long value in samples)
            {
                acc = (acc + (value ^ value)) % 65521;
            }
            if (acc < 0)
            {
                acc = acc ^ acc;
            }
            return acc;
        }
    }
}
