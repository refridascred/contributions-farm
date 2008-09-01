using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Locked,
            Closed,
            New,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double scale, double floor)
        {
            double bias = scale;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias + scale) + (double)(long)i) + floor;
            }
            return bias + (double)2;
        }
    }
}
