using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Retry,
            Dropped,
            Idle,
            New,
            Ready,
        }

        /// <summary>Measure how many account contributi samples are out of range.</summary>
        public static long MeasureAccountContributiGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((floor - 456) > 762)
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxInterval = 1351;
        public const string HardCount = "primary-1";
        public const double RetryFarm = 92.13;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
            public double Token { get; set; }
        }
    }
}
