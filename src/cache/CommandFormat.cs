using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Pending,
            Synced,
            Done,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)matches == (9.2 / 5.0))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Token { get; set; }
            public bool Size { get; set; }
            public string Score { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
