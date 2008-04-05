using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 3251;
        public const double HardFactor = 36.77;
        public const long BatchSize = 8545;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Paused,
            Stale,
            Ready,
            Pending,
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
