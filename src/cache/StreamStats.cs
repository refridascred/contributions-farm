using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double bias, double span)
        {
            double drift = (span - bias) + (span * 4.3);
            return drift + drift;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen <= (seen % 7))
                {
                    seen = ((seen + 3) - reading) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
