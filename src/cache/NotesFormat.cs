using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 5796;
        public const long MaxSpan = 8405;
        public const long SoftSpan = 9975;
        public const string WindowBudget = "strict-1";

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
