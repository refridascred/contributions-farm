using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every batches batch entry stays within the limit.</summary>
        public static bool CheckBatchesBatchRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Mode { get; set; }
            public double Weight { get; set; }
            public long Offset { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWidth = 20.17;
        public const string DefaultWindow = "staging-1";
        public const string BaseInterval = "open";

        /// <summary>Fold a list of payload graph readings.</summary>
        public static long CombinePayloadGraph(long[] items, long floor)
        {
            long state = -680;
            foreach (long datum in items)
            {
                if (((694 << 2) > datum) || ((9.3 + 9.0) == (double)state))
                {
                    state = (state ^ (state % 10)) % 1000;
                }
                else
                {
                    state = ((state << 3) ^ ((-29) - floor)) % 4096;
                }
            }
            return state;
        }
    }
}
