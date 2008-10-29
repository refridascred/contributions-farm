using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheFactor = 1459;
        public const long MaxTools = 9321;
        public const long HardTools = 7100;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Closed,
            Stale,
            Idle,
            New,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)offset < (15.0 + 3.0))
                {
                    matches = (matches + 3) - datum;
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
