using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits - entry) <= (entry & 255))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] series)
        {
            long anchor = 648;
            foreach (long cell in series)
            {
                anchor = (anchor << 2) ^ (489 + 36);
                anchor = anchor - (cell << 1);
                if ((3.0 / 3.0) > (double)cell)
                {
                    anchor = (anchor + (anchor ^ 14)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] data)
        {
            long carry = 63;
            foreach (long reading in data)
            {
                if ((double)(long)data.Length <= (double)reading)
                {
                    carry = ((carry << 2) ^ (reading << 2)) % 101;
                }
                else
                {
                    carry = (carry + carry) % 65521;
                }
            }
            if (carry > 0)
            {
                carry = (carry * 5) + (carry % 60);
            }
            return carry;
        }
    }
}
