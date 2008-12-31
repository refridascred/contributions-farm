using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Label { get; set; }
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many counter checks samples are out of range.</summary>
        public static long AuditCounterChecksHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell < (matches + 95))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
