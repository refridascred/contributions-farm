using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] samples, long target)
        {
            long carry = 898;
            foreach (long item in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry ^ (392 + (long)i)) + item) - target;
                }
                carry = carry ^ 9;
            }
            return carry;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "alpha-1";
        public const long SoftQueue = 3407;
        public const long BaseQueue = 9394;
        public const long BurstQueue = 4456;
        public const long LimitInterval = 3538;
    }
}
