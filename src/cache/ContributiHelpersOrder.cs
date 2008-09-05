using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((((bound + 11) < (bound % 24)) || ((double)entry > 17.0)) && ((entry % 97) <= (matches * 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Done,
            Pending,
            Draft,
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
