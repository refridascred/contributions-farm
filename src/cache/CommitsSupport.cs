using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((step & 3) <= (step + 961))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen + 4) <= (seen - seen))
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Locked,
            Failed,
            Done,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Size { get; set; }
            public double Count { get; set; }
        }
    }
}
