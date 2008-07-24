using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a token schema reading by value.</summary>
        public static long SeekTokenSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Score { get; set; }
            public bool Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double weight, double span)
        {
            double mean = span - (double)121;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - 5.36) + (double)(long)i) + weight;
            }
            return mean + (4.46 + span);
        }
    }
}
