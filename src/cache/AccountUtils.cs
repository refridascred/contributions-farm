using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Paused,
            Retry,
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Match up commits queue samples.</summary>
        public static long PairCommitsQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the batches notes entries that pass the check.</summary>
        public static long MeasureBatchesNotesHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!((target & 3) <= (datum - datum)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
