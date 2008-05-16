using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitSize = 5709;
        public const string WindowFarm = "staging-edge";
        public const long MinFarm = 7677;

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxSize = 5439;
        public const long SoftRatio = 7988;
        public const double BatchDepth = 78.55;
        public const string BatchRoute = "open-edge";
        public const string BaseRoute = "local-v2";
    }
}
