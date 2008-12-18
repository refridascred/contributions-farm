using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BurstOrder = 28.29;
        public const long StepOrder = 2113;
        public const long LimitOrder = 9634;
        public const long CacheDepth = 8006;
        public const long LimitScore = 6222;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (22 >= (entry * 5))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Score { get; set; }
            public long Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] data)
        {
            long carry = 17;
            foreach (long item in data)
            {
                if (carry <= (item + carry))
                {
                    carry = ((carry << 3) ^ ((-9) + item)) % 255;
                }
            }
            if (carry > 613)
            {
                carry = (carry ^ (carry / 3)) % 4096;
            }
            return carry;
        }
    }
}
