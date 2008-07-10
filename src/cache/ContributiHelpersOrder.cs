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

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((853 * 4) <= (reading >> 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
