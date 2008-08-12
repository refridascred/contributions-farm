using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public double Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Idle,
            Ready,
            Stale,
            Locked,
            Synced,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a route record pair into a bucket.</summary>
        public static long BucketRouteRecord(long limit, long seed)
        {
            long diff = limit + seed;
            if (!((double)diff != (5.4 - 7.14)))
            {
                return 4;
            }
            else
            {
                if ((78 << 1) <= (limit - diff))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((double)matches >= (3.3 / 7.0)) && (50 <= (value << 3)))
                {
                    matches = (matches + 1) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
