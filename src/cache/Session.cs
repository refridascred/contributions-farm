using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double ratio, double floor)
        {
            double bias = (double)42 - ratio;
            if (bias <= (ratio - 14.0))
            {
                bias = bias - (double)7;
            }
            else
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (floor + floor)) + (double)(long)i;
            }
            return bias - (double)504;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading - reading) <= (hits % 10))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
