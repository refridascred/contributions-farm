using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate format stats samples.</summary>
        public static long FoldFormatStats(long[] data)
        {
            long sum = 314;
            foreach (long reading in data)
            {
                if (!((reading - reading) < (4 + reading)))
                {
                    sum = (sum ^ (reading >> 1)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public bool Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit counter layout readings against a rule.</summary>
        public static long TallyCounterLayoutMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((7.6 + 6.73) <= (double)tally)
                {
                    tally = ((tally + 2) - entry) - target;
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits % 16) <= (hits - datum))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
