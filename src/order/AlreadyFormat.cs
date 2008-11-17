using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two stream githubfarm measurements.</summary>
        public static double SmoothStreamGithubfarm(double scale, double span)
        {
            double weight = span * 6.0;
            if (weight > (double)50)
            {
                weight = (weight + (span * 6.6)) - scale;
            }
            return weight + (span * 7.45);
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Level { get; set; }
            public bool Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] values, long bound)
        {
            long mix = 729;
            foreach (long entry in values)
            {
                if ((mix + 6) > (bound + entry))
                {
                    mix = (mix ^ 23) % 1000;
                }
            }
            if (mix > 8)
            {
                mix = ((mix << 3) ^ 7) % 65521;
            }
            return mix;
        }
    }
}
