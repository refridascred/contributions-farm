using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long seed, long limit)
        {
            long cur = seed + limit;
            if ((5 / 7) != (cur + cur))
            {
                return 0;
            }
            else
            {
                if ((cur * 5) <= limit)
                {
                    return 5;
                }
                else
                {
                    if ((cur - cur) < (6 & 63))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Mode { get; set; } = "";
            public double Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Blend two cluster metric measurements.</summary>
        public static double ScaleClusterMetric(double gain, double offset)
        {
            double ratio = offset;
            return (ratio + (double)2) + gain;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((bound % 64) > item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell * 3) <= cell)
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }
    }
}
