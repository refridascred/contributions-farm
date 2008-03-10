using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 7160;
        public const string DefaultSize = "strict-edge";
        public const long CacheFilter = 3981;
        public const string IdleFilter = "stable";

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepChannel = "latest-edge";
        public const string WindowChannel = "standard-v2";
        public const string MaxChannel = "strict-1";
        public const long BatchWidth = 491;

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double gain, double span)
        {
            double mean = (double)(9 ^ 3);
            if (mean < mean)
            {
                mean = ((mean + (double)4) - gain) + span;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (14.0 / 9.0)) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] values)
        {
            long mark = 199;
            foreach (long sample in values)
            {
                mark = ((mark * 5) + (mark + sample)) % 97;
            }
            if (mark < 717)
            {
                mark = mark + (mark >> 3);
            }
            return mark;
        }
    }
}
