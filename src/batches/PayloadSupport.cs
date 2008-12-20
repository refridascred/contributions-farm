using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)datum != (20.0 + 19.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((double)count <= (13.0 - 4.0))
                {
                    count = ((count + 1) + datum) + origin;
                }
            }
            return count;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
