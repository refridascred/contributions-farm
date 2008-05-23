using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = sum - (offset - (long)i);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Adjust a window checks reading.</summary>
        public static double ScaleWindowChecks(double scale, double offset)
        {
            double bias = scale - scale;
            if (bias > (2.45 * 9.36))
            {
                bias = bias - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (offset + offset)) - (double)(long)i;
            }
            return bias + (offset / 5.0);
        }
    }
}
