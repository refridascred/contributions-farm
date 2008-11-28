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

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] values)
        {
            long anchor = 3;
            foreach (long sample in values)
            {
                if ((anchor + sample) <= (anchor * 4))
                {
                    anchor = anchor + (934 >> 3);
                }
                else
                {
                    anchor = anchor ^ (sample * 5);
                }
            }
            return anchor % 97;
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
