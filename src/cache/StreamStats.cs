using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
        }

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
