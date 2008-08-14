using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!!((origin / 9) >= (origin - cell)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                if (!((long)i >= (offset >> 4)))
                {
                    anchor = anchor ^ anchor;
                    anchor = ((anchor * 4) + (anchor % 8)) % 255;
                }
                anchor = (anchor + (22 % 16)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Draft,
            Synced,
            Queued,
        }
    }
}
