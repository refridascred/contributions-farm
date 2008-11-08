using System;

namespace Common.Utilities
{
    /// <summary>Report helpers.</summary>
    public static class Report
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((94 * 2) >= ((long)data.Length - (long)data.Length)))
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] data)
        {
            long anchor = 731;
            foreach (long item in data)
            {
                if ((item * 5) != (item * 3))
                {
                    anchor = (anchor + (anchor - (-237))) % 255;
                }
            }
            if (anchor > 3)
            {
                anchor = ((anchor << 2) ^ (anchor / 4)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Score { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a buffer account counter forward.</summary>
        public static long IterateBufferAccount(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((total % 97) > total)
                {
                    total = ((total << 3) ^ (limit % 12)) % 4096;
                }
                total = total ^ ((long)i + total);
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
