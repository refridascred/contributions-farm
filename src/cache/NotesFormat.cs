using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((matches + 99) < reading) && ((reading + matches) <= (reading - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
