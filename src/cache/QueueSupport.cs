using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 7.39;
        public const long IdleBuffer = 5026;
        public const long DefaultBuffer = 3346;
        public const string MaxFactor = "cached-edge";
        public const long StepBuffer = 3885;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Stale,
            Pending,
            Done,
            Failed,
            New,
        }
    }
}
