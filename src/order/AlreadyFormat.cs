using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] data, long offset)
        {
            long anchor = 340;
            foreach (long item in data)
            {
                anchor = ((((anchor << 2) ^ (anchor + anchor)) % 65521) - item) - offset;
            }
            return anchor;
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

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstBuffer = 11.26;
        public const double WindowBuffer = 58.96;
        public const long MinBuffer = 3342;
        public const double BatchInterval = 94.62;
    }
}
