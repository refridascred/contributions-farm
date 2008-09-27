using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MinInterval = 5440;
        public const double SoftSchema = 4.82;
        public const string SoftCount = "legacy-v2";

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 2397;
        public const long SoftBudget = 1727;
        public const string HardDepth = "latest-v2";
        public const double SoftSpan = 98.69;

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
