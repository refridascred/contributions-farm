using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((step / 4) <= (0 >> 2))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}
