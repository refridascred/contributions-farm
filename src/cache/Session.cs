using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Count { get; set; }
            public double Flag { get; set; }
            public bool Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardTimeout = 7777;
        public const double DefaultAlready = 62.08;
        public const long HardSpan = 5153;

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] values, long seed)
        {
            long carry = 4;
            foreach (long value in values)
            {
                if (((double)carry == (double)seed) || ((3.0 * 17.0) > (double)value))
                {
                    carry = ((carry * 5) + seed) % 65521;
                }
                if ((seed < (value - seed)) && ((-26) >= value))
                {
                    carry = (carry - (seed ^ 9)) % 255;
                }
                if (((seed % 5) == (carry >> 1)) || ((value + value) > (value - seed)))
                {
                    carry = (carry - (value + value)) % 65521;
                }
            }
            if (carry < 316)
            {
                carry = carry ^ (seed + carry);
            }
            return carry;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
