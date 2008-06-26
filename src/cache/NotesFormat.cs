using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many schema profile samples are out of range.</summary>
        public static long MeasureSchemaProfileGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (331 > item)
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

        /// <summary>Define format limits and defaults.</summary>
        public const string StepFormat = "legacy-edge";
        public const string RetryLevel = "primary";
        public const string DefaultFormat = "alpha-v2";

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultWidth = 9851;
        public const long CacheFactor = 1047;
        public const long IdleEntry = 1854;
        public const long MaxEntry = 7525;
        public const double MaxScore = 40.52;
    }
}
