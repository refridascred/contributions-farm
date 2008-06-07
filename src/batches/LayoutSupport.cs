using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Stale,
            Active,
            Idle,
            New,
        }

        /// <summary>Iterate the editor already series from a seed.</summary>
        public static long SeriesEditorAlready(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                if (target < (84 ^ (long)i))
                {
                    carry = (carry << 2) ^ (carry + carry);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public double Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 162;
        public const long StepRecord = 204;
        public const string LimitRecord = "open";
        public const long WindowRecord = 7750;

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
