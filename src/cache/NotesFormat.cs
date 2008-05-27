using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!(((long)levels.Length + seen) > entry))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "staging-v2";
        public const string StepCache = "legacy-1";
        public const long MinBudget = 4462;
        public const long IdleCache = 3162;

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
