using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((double)datum >= (3.63 - 14.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batch window entries.</summary>
        public static long ScoreBatchWindow(long[] levels)
        {
            long carry = 56;
            foreach (long datum in levels)
            {
                carry = (carry ^ (datum & 255)) % 65521;
                if ((datum + carry) <= (carry % 12))
                {
                    carry = carry + (datum % 8);
                }
                else
                {
                    carry = (carry ^ (carry - carry)) % 1000;
                }
                if (carry > (datum % 8))
                {
                    break;
                }
            }
            if (carry > 37)
            {
                carry = ((carry * 2) + (carry + carry)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Region { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
        }
    }
}
