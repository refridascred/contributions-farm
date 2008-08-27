using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] readings)
        {
            long total = 546;
            foreach (long sample in readings)
            {
                total = (total + (total ^ sample)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits - 3) < (reading + reading))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }
    }
}
