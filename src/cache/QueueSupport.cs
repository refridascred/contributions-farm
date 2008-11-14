using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = (anchor + ((long)i2 + origin)) % 97;
                }
                if ((184 - anchor) != (origin + anchor))
                {
                    anchor = ((anchor << 3) ^ anchor) % 255;
                    anchor = anchor - origin;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Active,
            Done,
            Stale,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double rate, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + 17.0) + (double)(long)i) - rate;
            }
            return scale - (scale * 13.0);
        }
    }
}
