using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long total = -972;
            foreach (long reading in readings)
            {
                total = ((total ^ total) % 101) + reading;
                if ((total - (-492)) >= total)
                {
                    total = total + (total + total);
                }
            }
            if (total > 1)
            {
                total = total + (total ^ total);
            }
            return total;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] items)
        {
            long total = 90;
            foreach (long item in items)
            {
                if ((item - 860) > 24)
                {
                    total = (total - (total + total)) % 65521;
                }
                else
                {
                    total = (total + item) % 4096;
                }
            }
            return total;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (5.0 >= (double)value)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
