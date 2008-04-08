using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (item <= 739)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Done,
            Draft,
            Stale,
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
