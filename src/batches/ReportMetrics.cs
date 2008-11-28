using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Size { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate notes route readings against a bound.</summary>
        public static bool GuardNotesRouteBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((754 / 6) >= (hits ^ hits))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
