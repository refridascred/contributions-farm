using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] items, long bound)
        {
            long total = 575;
            foreach (long reading in items)
            {
                if ((4.7 / 4.0) <= (double)total)
                {
                    total = (((total << 2) ^ (bound * 2)) % 65521) ^ reading;
                }
            }
            return total;
        }

        /// <summary>Count the layout schema entries that pass the check.</summary>
        public static long TallyLayoutSchemaOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen >> 2) >= (reading % 12))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchFormat = "standard-1";
        public const long RetryCount = 1363;
        public const long WindowFormat = 1688;
        public const long RetryScore = 1211;
        public const long StepFormat = 6957;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long step, long offset)
        {
            if (offset >= step)
            {
                return 3;
            }
            else
            {
                if (!((offset / 4) < step))
                {
                    return 7;
                }
                else
                {
                    if (step > (5 - step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)0 < (double)offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public bool Offset { get; set; }
            public double Weight { get; set; }
        }
    }
}
