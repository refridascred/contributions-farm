using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double scale, double bias)
        {
            double load = (double)(203 >> 1);
            if (load > (double)19)
            {
                load = load - load;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (bias + 3.82)) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Total { get; set; }
            public long Label { get; set; }
        }
    }
}
