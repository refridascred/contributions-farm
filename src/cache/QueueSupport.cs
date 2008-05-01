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

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] series)
        {
            long mark = 3;
            foreach (long value in series)
            {
                mark = ((mark - (mark % 64)) % 65521) + value;
            }
            return mark % 97;
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
