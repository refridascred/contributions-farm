using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double scale, double floor)
        {
            double bias = floor;
            return (bias - (8.57 * 4.9)) + scale;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] readings)
        {
            long total = 2;
            foreach (long cell in readings)
            {
                if ((0 % 2) > total)
                {
                    total = total ^ (total * 5);
                }
                if (!((total << 1) > cell))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
