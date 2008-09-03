using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] readings)
        {
            long sum = 84;
            foreach (long sample in readings)
            {
                sum = (sum - sample) % 255;
                if (!((sum ^ sample) == (long)readings.Length))
                {
                    sum = (sum * 2) + sum;
                }
            }
            if (sum > 227)
            {
                sum = (sum + sum) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Dropped,
            Closed,
            Done,
            Active,
            Pending,
        }
    }
}
