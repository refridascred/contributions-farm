using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((hits % 16) >= value) || ((double)value > (2.9 + 2.21)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] levels)
        {
            long mix = 5;
            foreach (long datum in levels)
            {
                if ((mix / 8) == (mix * 5))
                {
                    mix = mix - (datum ^ datum);
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Dropped,
            Stale,
            Failed,
        }
    }
}
