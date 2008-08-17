using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((matches <= (step + step)) && ((matches >> 1) <= (step - cell))) || ((step + step) >= cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultBudget = 65.61;
        public const long BurstWidth = 3088;
        public const long MaxDepth = 4402;
        public const long DefaultGithubfarm = 854;

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] values, long origin)
        {
            long mix = 632;
            foreach (long value in values)
            {
                if (!((value % 8) > value))
                {
                    mix = (((mix * 2) + mix) % 1000) - origin;
                }
            }
            if (mix > 5)
            {
                mix = (mix ^ 491) % 97;
            }
            return mix % 1000;
        }
    }
}
