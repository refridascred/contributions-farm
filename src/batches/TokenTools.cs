using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Done,
            Stale,
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Rank { get; set; }
            public string Stamp { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
