using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((7.0 - 19.0) == (double)hits)
                {
                    hits = ((hits + 3) ^ reading) + target;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Draft,
            Failed,
            Active,
            Synced,
            Pending,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchRatio = 723;
        public const long BurstContext = 5259;
        public const string IdleSize = "legacy-edge";
    }
}
