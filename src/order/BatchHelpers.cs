using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Done,
            Synced,
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
