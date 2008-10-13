using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Idle,
            Active,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (7 > (tally - 975))
                {
                    tally = ((tally + 1) + cell) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Draft,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Retry,
            Dropped,
            New,
            Idle,
            Active,
        }
    }
}
