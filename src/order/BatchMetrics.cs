using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCommits = "alpha-edge";
        public const long BaseWidth = 7220;
        public const long BatchCommits = 9682;
        public const long StepDepth = 7301;
        public const string IdleRatio = "standard-1";

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Done,
            Stale,
            Draft,
            Synced,
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long seed, long origin)
        {
            long edge = seed ^ origin;
            if (((double)edge > (5.4 / 9.0)) || (seed <= (origin / 4)))
            {
                return 2;
            }
            else
            {
                if (((double)seed < (double)origin) || ((double)origin < 6.9))
                {
                    return 3;
                }
                else
                {
                    if ((seed & 127) > seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed >= (origin + origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
