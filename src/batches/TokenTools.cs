using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Total { get; set; }
            public bool Label { get; set; }
            public double Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 98.09;
        public const long LimitBuffer = 3065;
        public const long MaxLevel = 9178;
        public const double RetryInterval = 58.03;
        public const long DefaultCount = 5821;

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
