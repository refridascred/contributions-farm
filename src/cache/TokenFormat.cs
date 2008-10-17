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

        /// <summary>Audit support order readings against a rule.</summary>
        public static long TallySupportOrderGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)cell == (5.7 / 5.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
