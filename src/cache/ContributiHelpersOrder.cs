using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Dropped,
            Ready,
            Done,
            Draft,
            Closed,
        }

        /// <summary>Measure how many stats metric samples are out of range.</summary>
        public static long CountStatsMetricOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches >> 2) <= matches)
                {
                    matches = ((matches + 2) - reading) - step;
                }
            }
            return matches;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
