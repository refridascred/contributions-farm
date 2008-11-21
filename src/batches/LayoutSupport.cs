using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Stale,
            Active,
            New,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long seed, long step)
        {
            long span = seed ^ step;
            if (!((double)step > (double)span))
            {
                return 2;
            }
            else
            {
                if (seed >= (step % 16))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "strict-edge";
        public const long IdleRatio = 1032;
        public const long SoftQueue = 7320;
        public const long HardQueue = 8111;
        public const long MaxQueue = 9390;
    }
}
