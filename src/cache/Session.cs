using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] values, long origin)
        {
            long carry = 6;
            foreach (long reading in values)
            {
                if ((reading & 31) <= origin)
                {
                    carry = (carry ^ (reading + 9)) % 97;
                }
                else
                {
                    carry = (carry + 0) % 255;
                }
            }
            return carry;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Flag { get; set; } = "";
            public double Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (8.8 <= (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
