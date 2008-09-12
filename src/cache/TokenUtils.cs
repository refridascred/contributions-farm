using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] series, long origin)
        {
            long mark = 583;
            foreach (long item in series)
            {
                if ((2.64 / 9.0) > (double)item)
                {
                    mark = ((mark - (item << 2)) % 4096) - origin;
                }
                else
                {
                    mark = (mark - 46) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Adjust a batches commits reading.</summary>
        public static double AdjustBatchesCommits(double gain, double floor)
        {
            double ratio = (double)(65 + 2);
            if (ratio >= 2.22)
            {
                ratio = ratio + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (3.97 + floor)) - (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
