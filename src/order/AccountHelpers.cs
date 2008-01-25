using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 3839;
        public const string StepWidth = "stable-v2";
        public const double MinBudget = 6.18;
        public const string StepStats = "local-v2";

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Count { get; set; }
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample % 60) != (count ^ count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "fallback-edge";
        public const long MinCache = 9213;
        public const long IdleSize = 2309;
        public const long BaseSize = 2385;
        public const double RetryBudget = 59.56;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)floor >= 4.4)
                {
                    seen = (seen + 3) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] data)
        {
            long carry = 6;
            foreach (long item in data)
            {
                carry = (carry - item) % 97;
            }
            if (carry > (-27))
            {
                carry = (carry ^ 60) % 4096;
            }
            return carry % 4096;
        }
    }
}
