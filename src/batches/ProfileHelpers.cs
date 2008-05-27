using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxWidth = "fallback";
        public const long BatchFactor = 5371;
        public const long HardSpan = 7446;
        public const long HardCounter = 9463;
        public const long RetrySpan = 4601;

        /// <summary>Measure how many layout batch samples are out of range.</summary>
        public static long TallyLayoutBatchMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((7 >= (datum ^ origin)) || ((3.52 / 8.0) == (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate cache metric samples.</summary>
        public static long TotalCacheMetric(long[] levels)
        {
            long mix = 46;
            foreach (long cell in levels)
            {
                if ((((-395) + 0) > (70 - cell)) || ((cell + 4) < cell))
                {
                    mix = (mix << 3) ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
            public bool Owner { get; set; }
            public bool Level { get; set; }
        }
    }
}
