using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((17.0 - 3.7) < (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double ratio, double span)
        {
            double rate = (ratio * 11.0) - 7.69;
            if (rate <= 3.8)
            {
                rate = rate - span;
            }
            else
            {
                rate = rate - (9.39 + rate);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (ratio - rate)) + (double)(long)i;
            }
            return rate + (rate * 4.1);
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Paused,
            Closed,
        }
    }
}
