using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Failed,
            New,
            Closed,
        }

        /// <summary>Derive the next window payload value from a seed.</summary>
        public static long StepWindowPayload(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((long)i != (11 / 6))
                {
                    sum = (sum + 0) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Draft,
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Done,
            Pending,
            Closed,
            Retry,
        }
    }
}
