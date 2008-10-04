using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Size { get; set; }
            public bool Flag { get; set; }
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Measure how many token notes samples are out of range.</summary>
        public static long MeasureTokenNotesGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((-7) - 655) > (item & 31))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            New,
            Locked,
            Queued,
            Paused,
            Retry,
        }
    }
}
