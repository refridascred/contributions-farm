using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double StepSize = 57.66;
        public const long BurstEditor = 2166;
        public const long MinEditor = 9141;
        public const long SoftEditor = 1257;
        public const double WindowSpan = 95.61;

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            New,
            Ready,
            Pending,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                state = (state << 3) ^ step;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Limit { get; set; }
            public double Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
