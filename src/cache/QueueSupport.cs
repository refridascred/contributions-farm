using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BatchCount = "cached";
        public const long IdleWindow = 9060;
        public const string MinWindow = "alpha-1";
        public const long BurstFactor = 4854;
        public const long StepInterval = 1543;

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] readings, long limit)
        {
            long sum = 9;
            foreach (long datum in readings)
            {
                if ((double)limit == (7.66 - 5.2))
                {
                    sum = ((sum << 3) ^ (limit * 2)) ^ datum;
                }
            }
            return sum;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Draft,
            Synced,
            Failed,
            New,
        }
    }
}
