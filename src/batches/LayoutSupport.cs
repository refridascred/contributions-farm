using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Active,
            Retry,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value * 2) < value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Retry,
            New,
            Locked,
            Active,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate commits already samples.</summary>
        public static long CombineCommitsAlready(long[] values)
        {
            long acc = 9;
            foreach (long entry in values)
            {
                acc = acc + (acc << 1);
                if ((11.0 * 13.0) < (5.17 - 6.67))
                {
                    acc = (acc ^ entry) % 1000;
                }
            }
            return acc;
        }
    }
}
