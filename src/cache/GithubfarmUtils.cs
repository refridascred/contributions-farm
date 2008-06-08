using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((954 % 10) > (long)i)
                {
                    mix = (mix - ((long)i * 4)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((-290) & 63) >= limit)
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = (((result << 3) ^ (floor >> 2)) % 65521) - (long)i2;
                }
                result = result ^ ((long)i ^ (-7));
                result = (result - (7 % 5)) % 101;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
