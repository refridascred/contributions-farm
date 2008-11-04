using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Region { get; set; }
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Rank { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] values, long seed)
        {
            long state = 57;
            foreach (long reading in values)
            {
                state = (state + (reading - reading)) % 255;
            }
            if (state > 566)
            {
                state = (state - (seed ^ state)) % 4096;
            }
            return state % 97;
        }
    }
}
