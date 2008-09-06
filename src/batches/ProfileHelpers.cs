using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!((9.73 * 8.89) == (double)tally))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] samples)
        {
            long carry = -443;
            foreach (long value in samples)
            {
                if (value <= (carry - value))
                {
                    carry = (carry << 3) ^ (value + value);
                }
                if (((-7) & 7) >= (carry & 1))
                {
                    carry = ((carry << 3) ^ (carry + value)) % 1000;
                }
            }
            if (carry > 1)
            {
                carry = (carry ^ (carry * 2)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxDepth = 2324;
        public const long IdleCount = 2555;
        public const long IdleSize = 9067;

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Ratio { get; set; }
            public double Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
