using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count schema window pairs that satisfy a relation.</summary>
        public static long PairSchemaWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many metric session samples are out of range.</summary>
        public static long MeasureMetricSessionHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((double)tally <= (double)cell) || (cell >= (tally + cell)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
