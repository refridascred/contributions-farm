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

        /// <summary>Validate account queue readings against a bound.</summary>
        public static bool ValidateAccountQueueLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
