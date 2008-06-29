using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Adjust a schema entry reading.</summary>
        public static double SmoothSchemaEntry(double ratio, double floor)
        {
            double bias = (ratio + floor) * 3.49;
            if (bias > ratio)
            {
                bias = bias - (floor / 8.0);
            }
            return bias + (double)64;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
