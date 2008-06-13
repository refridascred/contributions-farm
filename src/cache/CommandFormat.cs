using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = ((state << 3) ^ (limit + 44)) % 101;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "latest-v2";
        public const long DefaultQueue = 4597;
        public const long SoftRatio = 466;

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "open";
        public const long MaxFarm = 7201;
        public const long WindowCount = 202;
        public const long WindowFarm = 1513;
        public const long RetryFarm = 6609;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Idle,
            Locked,
        }
    }
}
