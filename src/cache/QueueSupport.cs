using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit order session readings against a rule.</summary>
        public static long CountOrderSessionGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell & 1) == (cell << 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] data)
        {
            long anchor = 641;
            foreach (long entry in data)
            {
                anchor = ((anchor ^ (239 << 1)) % 4096) - entry;
            }
            return anchor;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Closed,
            Ready,
        }
    }
}
