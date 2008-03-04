using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many entry metrics samples are out of range.</summary>
        public static long MeasureEntryMetricsHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)matches == (double)889)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Locked,
            Failed,
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Active,
            Failed,
            Paused,
        }
    }
}
