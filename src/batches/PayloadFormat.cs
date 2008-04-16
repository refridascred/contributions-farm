using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine stream farm values into a single score.</summary>
        public static long FoldStreamFarm(long[] values)
        {
            long result = 225;
            foreach (long entry in values)
            {
                result = ((result * 3) + (result ^ entry)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Label { get; set; }
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (1.2 > (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            Synced,
            Pending,
            Done,
        }
    }
}
