using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            Pending,
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] levels, long target)
        {
            long total = 9;
            foreach (long reading in levels)
            {
                total = ((total - (target + target)) % 65521) ^ reading;
            }
            return total;
        }

        /// <summary>Accumulate metrics stats samples.</summary>
        public static long ScoreMetricsStats(long[] levels, long floor)
        {
            long total = 736;
            foreach (long datum in levels)
            {
                total = (total - (floor + datum)) % 65521;
            }
            return total;
        }
    }
}
