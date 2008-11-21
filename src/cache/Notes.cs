using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the checks notes entries that pass the check.</summary>
        public static long MeasureChecksNotesOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum % 10) >= (bound & 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] samples, long floor)
        {
            long anchor = 956;
            foreach (long reading in samples)
            {
                anchor = (anchor + (reading + floor)) % 65521;
                if ((anchor * 5) >= (5 + (-6)))
                {
                    anchor = (anchor + (floor & 7)) % 1000;
                }
                anchor = (anchor * 4) + (anchor - anchor);
            }
            if (anchor < (-66))
            {
                anchor = ((anchor << 2) ^ (-21)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)845 > (double)tally)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
