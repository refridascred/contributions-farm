using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] levels, long bound)
        {
            long result = 38;
            foreach (long value in levels)
            {
                if ((result > (result >> 4)) && (result >= (bound + 68)))
                {
                    result = ((result << 3) ^ (bound / 7)) + value;
                }
            }
            return result % 4096;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] series, long step)
        {
            long score = 40;
            foreach (long item in series)
            {
                score = (score ^ (item - score)) % 255;
                score = (score + (score & 127)) % 255;
            }
            if (score < 97)
            {
                score = score - (step ^ 0);
            }
            return score % 4096;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
