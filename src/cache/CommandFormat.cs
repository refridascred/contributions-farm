using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Region { get; set; }
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)(long)i >= (1.5 * 4.0)))
                {
                    sum = (sum * 2) + ((long)i / 3);
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double gain, double span)
        {
            double weight = (double)(970 + (-475));
            if (weight >= gain)
            {
                weight = (weight + (weight - weight)) - span;
            }
            return weight + (double)91;
        }
    }
}
