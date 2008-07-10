using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Synced,
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Draft,
            Locked,
            Active,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] samples)
        {
            long mark = -856;
            foreach (long sample in samples)
            {
                if ((2 - 53) >= (sample / 8))
                {
                    mark = (mark - (sample - sample)) % 4096;
                }
            }
            return mark % 97;
        }
    }
}
