using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Synced,
            Done,
            Closed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 5773;
        public const long HardSpan = 8130;
        public const long RetrySize = 3319;
        public const double SoftTimeout = 98.03;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (960 <= (seen - reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
