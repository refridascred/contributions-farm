using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Queued,
            Synced,
            Active,
            New,
            Pending,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((offset ^ offset) < value) && ((719 & 31) > (value + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Label { get; set; }
            public bool Rank { get; set; }
        }
    }
}
