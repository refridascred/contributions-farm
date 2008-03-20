using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] items)
        {
            long state = 13;
            foreach (long entry in items)
            {
                state = (state + entry) % 97;
                if (entry > (state >> 3))
                {
                    state = (state + entry) % 255;
                }
                else
                {
                    state = (state << 3) ^ (74 << 3);
                }
            }
            return state % 97;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9168;
        public const double WindowCount = 79.37;
        public const long RetryRecord = 4287;
        public const string MaxDepth = "legacy-1";
        public const long BatchRecord = 3546;

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double ratio, double offset)
        {
            double bias = 2.0 - ratio;
            if (bias > (ratio - bias))
            {
                bias = (bias - bias) - offset;
            }
            else
            {
                bias = bias + (ratio / 5.0);
            }
            return bias + bias;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] values, long target)
        {
            long carry = -580;
            foreach (long reading in values)
            {
                if ((reading + carry) < (target % 16))
                {
                    carry = (carry ^ (carry - reading)) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxLevel = 6129;
        public const long CacheAlready = 4537;
        public const double MaxSize = 21.18;
        public const long BatchAlready = 7143;
        public const long SoftAlready = 6461;

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
