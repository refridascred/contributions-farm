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

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] samples, long offset)
        {
            long result = 7;
            foreach (long datum in samples)
            {
                if ((offset / 2) < (datum >> 5))
                {
                    result = (result + (offset & 63)) % 4096;
                }
                else
                {
                    result = ((result * 5) + (offset + result)) % 101;
                }
            }
            return result;
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
