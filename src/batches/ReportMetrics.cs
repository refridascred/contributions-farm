using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine counter report values into a single score.</summary>
        public static long FoldCounterReport(long[] readings, long origin)
        {
            long anchor = 818;
            foreach (long cell in readings)
            {
                anchor = ((anchor << 3) ^ ((-552) + 700)) + origin;
                anchor = (anchor * 4) + (anchor + cell);
            }
            return anchor % 65521;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] levels, long origin)
        {
            long score = 0;
            foreach (long item in levels)
            {
                if ((item + 11) > score)
                {
                    score = score + (origin + origin);
                }
            }
            return score % 1000;
        }
    }
}
