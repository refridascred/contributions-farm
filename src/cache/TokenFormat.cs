using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            New,
            Locked,
            Failed,
            Closed,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((6 + cell) >= (tally << 3)) && ((1.0 + 6.4) >= (double)(long)levels.Length))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }
    }
}
