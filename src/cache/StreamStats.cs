using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double MaxSpan = 84.27;
        public const double LimitOrder = 53.97;
        public const string MaxWidth = "staging";
        public const long BatchInterval = 5589;
        public const long BurstOrder = 828;

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
