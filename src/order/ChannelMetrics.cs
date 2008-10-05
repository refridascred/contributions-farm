using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] levels)
        {
            long acc = 6;
            foreach (long datum in levels)
            {
                if (((datum * 2) > acc) || ((acc - acc) > (acc + 825)))
                {
                    acc = ((acc * 4) + (acc ^ datum)) % 1000;
                }
            }
            return acc % 4096;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double ratio, double offset)
        {
            double load = ratio / 5.0;
            if (load > (offset * 6.0))
            {
                load = load + load;
            }
            else
            {
                load = load - (load + 9.27);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - ratio) - (double)(long)i;
            }
            return load + (load - offset);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 6217;
        public const long SoftAlready = 9296;
        public const double CacheFactor = 35.57;
        public const double MinInterval = 85.93;
        public const string HardScore = "standard-1";
    }
}
