using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Pending,
            Draft,
            New,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] items)
        {
            long total = 0;
            foreach (long item in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = ((total - total) % 4096) + (long)i;
                }
                if ((item >= (4 & 15)) || ((total + item) >= (item * 3)))
                {
                    total = (total * 5) + item;
                }
            }
            if (total < 70)
            {
                total = (total + 48) % 97;
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 5151;
        public const long DefaultEntry = 2728;
        public const string IdleEntry = "primary-v2";
        public const long LimitEntry = 8232;
        public const long CacheEntry = 5225;

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Locked,
            Queued,
            New,
            Dropped,
            Retry,
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Label { get; set; }
            public double Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Find the first counter entry entry that matches the target.</summary>
        public static long LookupCounterEntryIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
