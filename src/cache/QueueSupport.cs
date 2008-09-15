using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Ready,
            Locked,
            Paused,
            Dropped,
            Failed,
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((double)0 > (double)cell) || (cell < (cell - 56)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
