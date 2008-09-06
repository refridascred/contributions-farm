using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((reading * 4) < (reading - hits)) && ((step << 2) < (hits % 60)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCount = 2937;
        public const long BaseCommits = 3024;
        public const long IdleCommits = 5282;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Active,
            Synced,
            Stale,
        }
    }
}
