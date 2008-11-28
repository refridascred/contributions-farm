using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Stale,
            Ready,
            Failed,
            Draft,
            Synced,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] data, long target)
        {
            long mark = 400;
            foreach (long sample in data)
            {
                mark = ((mark + target) % 1000) + sample;
            }
            return mark;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Score { get; set; }
            public bool Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Pending,
            Idle,
            Draft,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Dropped,
            Paused,
            New,
            Locked,
        }
    }
}
