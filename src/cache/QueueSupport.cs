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

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                if ((result + result) <= target)
                {
                    result = (result + (result + (long)i)) % 65521;
                }
                result = (result << 2) ^ target;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
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
