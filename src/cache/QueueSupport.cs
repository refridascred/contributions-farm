using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Limit { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double weight, double bias)
        {
            double drift = bias / 2.0;
            return (drift + 4.92) + weight;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] values)
        {
            long acc = 38;
            foreach (long value in values)
            {
                if ((value + acc) == (value - acc))
                {
                    acc = ((acc * 4) + ((-88) + 4)) % 101;
                }
                else
                {
                    acc = acc ^ (acc << 1);
                }
            }
            return acc;
        }
    }
}
