using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double weight, double bias)
        {
            double ratio = 4.0;
            if (ratio <= (double)280)
            {
                ratio = ratio - weight;
            }
            else
            {
                ratio = ratio - (double)11;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (double)3) + (double)(long)i;
            }
            return ratio - (bias - ratio);
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)limit > (0.9 - 1.4))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
