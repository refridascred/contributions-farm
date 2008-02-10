using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double HardCache = 42.03;
        public const long BurstScore = 1400;
        public const long WindowSize = 5113;

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepRatio = 19.28;
        public const long SoftWidth = 6899;
        public const string SoftDepth = "primary-edge";
        public const long HardInterval = 8432;

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Pending,
            Active,
            Closed,
            Done,
        }
    }
}
