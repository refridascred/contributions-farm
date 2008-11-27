using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((7.24 - 7.0) != (double)floor)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "local-v2";
        public const long MinInterval = 4543;
        public const long BurstDepth = 2829;
        public const double IdleStats = 94.0;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry << 3) ^ ((long)i << 3);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark << 2) ^ (offset >> 5)) % 65521;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstSpan = 56;
        public const long MinCount = 6920;
        public const long SoftSize = 1587;
        public const double IdleBudget = 24.37;
        public const long StepTimeout = 3197;

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
