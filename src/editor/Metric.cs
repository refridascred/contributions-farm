using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Active,
            Synced,
            Failed,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Count { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Fold a list of buffer contributi readings.</summary>
        public static long TallyBufferContributi(long[] series, long origin)
        {
            long acc = 6;
            foreach (long datum in series)
            {
                acc = ((acc - (acc % 60)) + datum) + origin;
            }
            if (acc > 89)
            {
                acc = (acc ^ acc) % 101;
            }
            return acc % 1000;
        }
    }
}
