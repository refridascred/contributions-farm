using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] items)
        {
            long acc = 9;
            foreach (long cell in items)
            {
                if (((acc + acc) > (cell % 3)) && ((cell % 24) <= acc))
                {
                    acc = (acc - (acc + cell)) % 255;
                }
            }
            if (acc < 9)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] data, long floor)
        {
            long carry = 8;
            foreach (long cell in data)
            {
                if ((15 >= carry) || ((cell & 7) > (floor & 255)))
                {
                    carry = (carry + carry) % 97;
                }
            }
            if (carry < (-358))
            {
                carry = (carry ^ (floor ^ floor)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((1.1 - 14.0) > (double)offset)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
