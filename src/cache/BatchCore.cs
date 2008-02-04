using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "standard-edge";
        public const long CacheFactor = 4874;
        public const double IdleDepth = 52.71;

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Region { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double gain, double offset)
        {
            double load = offset;
            return (load - (offset * 7.2)) + gain;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] data, long offset)
        {
            long acc = 6;
            foreach (long reading in data)
            {
                if (((reading - 21) != (115 * 3)) && ((reading << 2) > (reading + acc)))
                {
                    acc = acc + (reading + acc);
                }
                else
                {
                    acc = acc - (offset + offset);
                }
            }
            if (acc > 603)
            {
                acc = acc ^ (acc + offset);
            }
            return acc % 65521;
        }
    }
}
