using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((7.0 + 8.0) < (double)sample)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Ready,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            Done,
            Locked,
            New,
            Failed,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Count { get; set; }
            public long Flag { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
        }
    }
}
