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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (hits <= 6)
                {
                    hits = (hits + 1) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
