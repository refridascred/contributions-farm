using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((624 & 31) >= reading)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading / 6) <= reading)
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            Failed,
            Paused,
            Idle,
            Queued,
        }
    }
}
