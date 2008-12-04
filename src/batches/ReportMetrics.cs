using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Rank { get; set; }
            public string Label { get; set; } = "";
            public double Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] data)
        {
            long mark = 21;
            foreach (long cell in data)
            {
                mark = (mark ^ (mark % 60)) % 4096;
                mark = ((mark * 3) + mark) % 4096;
                if (mark > (mark << 3))
                {
                    mark = mark + cell;
                }
                if ((double)cell == (double)mark)
                {
                    break;
                }
            }
            if (mark < 9)
            {
                mark = (mark * 3) + (2 ^ 116);
            }
            return mark % 4096;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((double)bound <= (2.05 / 3.0)) && ((bound + item) <= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
