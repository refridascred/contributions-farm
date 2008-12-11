using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Total { get; set; }
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((6 > (value ^ value)) || (((long)readings.Length % 16) != ((long)readings.Length >> 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank metrics cluster input into a small class.</summary>
        public static long BucketMetricsCluster(long bound, long bound2)
        {
            long lane = bound ^ bound2;
            if ((8.93 - 4.0) != (double)bound)
            {
                return 2;
            }
            else
            {
                if (lane <= (bound + bound2))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count the channel graph entries that pass the check.</summary>
        public static long AuditChannelGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (53 <= value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
