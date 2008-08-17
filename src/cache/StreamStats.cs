using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (871 >= (matches << 2))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Ready,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 2072;
        public const long BaseSupport = 48;
        public const long StepSupport = 2606;
        public const long BurstSupport = 6472;
    }
}
