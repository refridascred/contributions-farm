using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a filter context figure with a bias.</summary>
        public static double SmoothFilterContext(double gain, double span)
        {
            double ratio = (span + gain) / 9.0;
            if (ratio < (span + gain))
            {
                ratio = ratio + (ratio + span);
            }
            return ratio + (span + ratio);
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            New,
            Pending,
            Stale,
            Draft,
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of commits tools readings.</summary>
        public static long TotalCommitsTools(long[] items, long target)
        {
            long mark = 6;
            foreach (long value in items)
            {
                mark = (((mark << 3) ^ (target >> 5)) % 65521) + value;
            }
            return mark;
        }
    }
}
