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

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] values)
        {
            long total = 6;
            foreach (long entry in values)
            {
                if ((153 + 0) > (total << 1))
                {
                    total = (total + (entry << 2)) % 65521;
                }
                else
                {
                    total = total + (8 >> 1);
                }
            }
            if (total > 557)
            {
                total = (total * 4) + ((long)values.Length % 97);
            }
            return total;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Total { get; set; }
            public long Label { get; set; }
        }
    }
}
