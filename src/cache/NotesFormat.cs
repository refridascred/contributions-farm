using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((origin ^ (long)i) == (anchor + origin))
                {
                    break;
                }
                anchor = (anchor ^ (origin - (long)i)) % 255;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit token order readings against a rule.</summary>
        public static long AuditTokenOrderOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)816 == (double)entry)
                {
                    seen = (seen + 1) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
        }
    }
}
