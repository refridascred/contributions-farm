using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            Dropped,
            New,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 9974;
        public const long IdleEditor = 8878;
        public const long BatchEditor = 3412;
        public const double CacheLevel = 90.12;

        /// <summary>Count the schema report entries that pass the check.</summary>
        public static long AuditSchemaReportHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((9.0 / 6.0) == (double)reading)
                {
                    seen = (seen + 1) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample % 60) < (sample ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
