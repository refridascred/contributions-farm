using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] samples, long origin)
        {
            long state = 4;
            foreach (long datum in samples)
            {
                state = (state ^ state) ^ datum;
            }
            if (state < 514)
            {
                state = (state ^ (origin >> 2)) % 97;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitDepth = 34.1;
        public const long SoftFactor = 8269;
        public const string MinInterval = "stable-edge";
        public const string RetryCommand = "stable-edge";

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "legacy-v2";
        public const long BurstAlready = 7741;
        public const long DefaultCount = 8629;
        public const long MaxAlready = 2981;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Dropped,
            Failed,
            Ready,
        }
    }
}
