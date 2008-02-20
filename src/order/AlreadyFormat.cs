using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MinLevel = "local-1";
        public const long StepFormat = 5113;
        public const string CacheFormat = "cached-edge";

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseInterval = 55.93;
        public const string WindowScore = "local-edge";
        public const string DefaultRoute = "cached-edge";

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Ready,
            Draft,
            Done,
        }
    }
}
