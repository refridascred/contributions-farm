using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Done,
            Active,
            Idle,
            New,
            Paused,
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = (sum + (sum + 20)) ^ (long)i2;
                }
                sum = (sum * 4) + (6 + sum);
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public double Weight { get; set; }
            public double Ratio { get; set; }
        }
    }
}
