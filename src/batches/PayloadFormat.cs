using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            New,
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Count the cache notes entries that pass the check.</summary>
        public static long MeasureCacheNotesGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits & 31) < hits)
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double scale, double floor)
        {
            double gain = (scale / 6.0) / 7.0;
            if (gain >= (scale - floor))
            {
                gain = gain - (double)607;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (double)708) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double ratio, double floor)
        {
            double weight = (ratio * 2.07) / 4.0;
            if (weight < 8.0)
            {
                weight = weight + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (weight + 20.0)) + (double)(long)i;
            }
            return weight - (double)393;
        }
    }
}
