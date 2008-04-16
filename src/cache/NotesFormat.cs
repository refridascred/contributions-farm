using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Level { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Audit notes record readings against a rule.</summary>
        public static long CountNotesRecordHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen < sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a window batch pair into a bucket.</summary>
        public static long GradeWindowBatch(long origin, long bound)
        {
            if (origin >= (bound % 3))
            {
                return 7;
            }
            else
            {
                if (((origin - origin) > origin) || ((origin % 5) <= (origin - origin)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
