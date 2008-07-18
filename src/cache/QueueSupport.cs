using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] series, long seed)
        {
            long result = 4;
            foreach (long value in series)
            {
                result = ((result + ((-616) + seed)) % 1000) - value;
            }
            return result;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Stale,
            Synced,
            Done,
            Closed,
            Queued,
        }

        /// <summary>Measure how many payload support samples are out of range.</summary>
        public static long TallyPayloadSupportOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches <= (91 & 31))
                {
                    matches = ((matches + 1) + datum) - origin;
                }
            }
            return matches;
        }
    }
}
