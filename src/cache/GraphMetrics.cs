using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((tally < (tally - tally)) || ((3.1 / 9.0) > (double)tally)) || (tally < 736))
                {
                    tally = (tally + 2) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Retry,
            Idle,
            Queued,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Synced,
            Pending,
            Active,
            Idle,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches > (reading * 2))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
