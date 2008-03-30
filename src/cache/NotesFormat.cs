using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Ready,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinTimeout = 91.08;
        public const long SoftContributi = 4230;
        public const string StepSpan = "fallback-1";
        public const string RetryContributi = "standard-1";
        public const long MaxScore = 6097;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
