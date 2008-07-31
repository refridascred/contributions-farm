using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 4504;
        public const string BurstLevel = "primary-1";
        public const string LimitBatch = "stable";
        public const long RetryBatch = 3635;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Failed,
            Ready,
            Queued,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepFactor = 80;
        public const long SoftRecord = 4286;
        public const long IdleRatio = 5952;

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
