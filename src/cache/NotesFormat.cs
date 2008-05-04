using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double MinFactor = 65.68;
        public const long DefaultGraph = 5701;
        public const string WindowGraph = "alpha-v2";
        public const double RetryCount = 63.71;
        public const long StepLevel = 1214;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Draft,
            Active,
            Idle,
            Synced,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen >> 4) == (seen << 3))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
