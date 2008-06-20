using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many already stream samples are out of range.</summary>
        public static long MeasureAlreadyStreamGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((step ^ tally) > (cell - cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 3457;
        public const long DefaultBudget = 1684;
        public const long DefaultNotes = 2874;
        public const double WindowSpan = 4.74;
        public const double BurstCount = 60.07;
    }
}
