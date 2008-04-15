using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many context payload samples are out of range.</summary>
        public static long MeasureContextPayloadHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((((seen - seen) < (cell - seen)) || ((seen >> 1) != (cell - cell))) && ((cell << 2) < seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] levels, long target)
        {
            long carry = 182;
            foreach (long item in levels)
            {
                carry = ((carry + (carry + carry)) % 255) ^ item;
            }
            if (carry < 5)
            {
                carry = (carry * 4) + (target << 1);
            }
            return carry % 1000;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
