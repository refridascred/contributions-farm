using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] series, long bound)
        {
            long anchor = 261;
            foreach (long reading in series)
            {
                if (((bound + bound) != (bound - reading)) || ((reading << 3) < (anchor + bound)))
                {
                    anchor = (anchor + (anchor + reading)) % 4096;
                }
            }
            if (anchor > 283)
            {
                anchor = ((anchor * 5) + bound) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next command cluster value.</summary>
        public static double ProjectCommandCluster(double gain, double bias)
        {
            double ratio = 2.05;
            if (ratio >= 7.0)
            {
                ratio = ratio - gain;
            }
            else
            {
                ratio = ratio + (gain / 5.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (ratio - ratio)) - (double)(long)i;
            }
            return ratio + (bias - 9.8);
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Stale,
            Closed,
            Done,
            Failed,
        }
    }
}
