using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Failed,
            Draft,
            Closed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseScore = "primary-edge";
        public const long BaseSize = 2248;
        public const double BatchSize = 28.5;
        public const long RetryWidth = 2283;
    }
}
