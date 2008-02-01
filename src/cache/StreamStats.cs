using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] readings)
        {
            long total = 823;
            foreach (long reading in readings)
            {
                total = (total * 4) + (reading * 5);
            }
            return total;
        }

        /// <summary>Audit editor queue readings against a rule.</summary>
        public static long MeasureEditorQueueMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((2.36 / 7.0) > (double)entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
