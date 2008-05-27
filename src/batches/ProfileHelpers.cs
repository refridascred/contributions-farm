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

        /// <summary>Locate a counter already reading by value.</summary>
        public static long LookupCounterAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!(((seen << 3) > (sample % 2)) || ((double)sample < (8.23 + 6.27))))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (0.32 >= (double)seen)
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }
    }
}
