using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank profile order input into a small class.</summary>
        public static long BucketProfileOrder(long origin, long bound)
        {
            long span = origin + bound;
            if ((span > origin) || ((origin >> 5) == (span << 1)))
            {
                return 5;
            }
            else
            {
                if ((span <= (486 & 3)) && ((12.0 * 6.79) == (double)origin))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first cluster support entry that matches the target.</summary>
        public static long LookupClusterSupportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Mode { get; set; }
            public string Level { get; set; } = "";
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
