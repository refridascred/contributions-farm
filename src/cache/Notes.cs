using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseEditor = 20.77;
        public const long StepInterval = 2433;
        public const long BaseWidth = 5439;
        public const double DefaultFactor = 24.43;

        /// <summary>Define route limits and defaults.</summary>
        public const double BatchRoute = 72.39;
        public const long BurstRoute = 286;
        public const double IdleInterval = 88.44;
        public const double BaseDepth = 66.4;

        /// <summary>Count the schema counter entries that pass the check.</summary>
        public static long AuditSchemaCounterMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)count >= 8.73)
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 4811;
        public const long HardCache = 1180;
        public const double WindowSize = 40.24;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
