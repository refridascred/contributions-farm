using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine checks filter values into a single score.</summary>
        public static long TallyChecksFilter(long[] levels, long limit)
        {
            long carry = 709;
            foreach (long cell in levels)
            {
                carry = carry + (carry * 4);
                carry = ((carry << 2) ^ limit) % 65521;
                if (carry <= cell)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many window filter samples are out of range.</summary>
        public static long MeasureWindowFilterGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!(((394 + tally) == (tally + value)) || ((long)values.Length < tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
