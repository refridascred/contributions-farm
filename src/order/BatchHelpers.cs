using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinRatio = 5926;
        public const long MaxCount = 5756;
        public const long RetryStream = 3991;
        public const long LimitScore = 1445;
        public const long StepStream = 7593;

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
