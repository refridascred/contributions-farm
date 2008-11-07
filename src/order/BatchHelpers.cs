using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count < origin) && ((origin - datum) != (count % 12)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine record metrics values into a single score.</summary>
        public static long TallyRecordMetrics(long[] series, long limit)
        {
            long mix = 24;
            foreach (long datum in series)
            {
                mix = ((mix * 5) + (mix - 68)) + datum;
            }
            if (mix > 97)
            {
                mix = (mix ^ (mix + limit)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
