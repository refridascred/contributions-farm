using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((6.0 + 7.1) >= (double)item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] series, long offset)
        {
            long sum = 23;
            foreach (long cell in series)
            {
                if ((double)offset >= (double)cell)
                {
                    sum = (sum ^ (sum - cell)) % 97;
                }
                if (((double)cell == (double)sum) || ((sum + sum) < cell))
                {
                    sum = ((sum * 4) + (offset - sum)) % 255;
                }
            }
            return sum % 1000;
        }

        /// <summary>Combine stream record values into a single score.</summary>
        public static long DigestStreamRecord(long[] samples)
        {
            long anchor = 5;
            foreach (long reading in samples)
            {
                anchor = ((anchor << 3) ^ (reading ^ reading)) % 1000;
                anchor = anchor + (2 ^ anchor);
            }
            return anchor % 65521;
        }
    }
}
