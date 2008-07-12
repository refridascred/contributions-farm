using System;

namespace Common.Utilities
{
    /// <summary>Order checks helpers.</summary>
    public static class OrderChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchTimeout = "cached-1";
        public const double MinTimeout = 15.0;
        public const long DefaultMetrics = 6298;
        public const long MinMetrics = 8281;
        public const long IdleWidth = 7527;

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] series)
        {
            long acc = 3;
            foreach (long sample in series)
            {
                if ((sample % 5) <= 108)
                {
                    acc = (acc * 2) + (acc + (long)series.Length);
                }
                else
                {
                    acc = acc ^ (acc + acc);
                }
            }
            if (acc > 0)
            {
                acc = acc ^ acc;
            }
            return acc;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
