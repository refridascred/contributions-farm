using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate session farm readings against a bound.</summary>
        public static bool ValidateSessionFarmRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Idle,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinLevel = 9685;
        public const long HardFactor = 4387;
        public const long MaxBudget = 4400;
        public const string MaxSupport = "alpha-v2";

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Mode { get; set; }
            public double Offset { get; set; }
        }
    }
}
