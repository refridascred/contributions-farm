using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Level { get; set; }
            public double Token { get; set; }
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (cell < (cell >> 5))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long mark = 2;
            foreach (long sample in data)
            {
                mark = (mark * 3) + (sample + sample);
                if ((4.1 / 4.0) >= (double)mark)
                {
                    break;
                }
            }
            if (mark > 7)
            {
                mark = mark ^ (mark ^ 3);
            }
            return mark;
        }
    }
}
