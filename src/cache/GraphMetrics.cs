using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long limit, long offset)
        {
            long delta = limit + offset;
            if ((86 + limit) <= (offset / 8))
            {
                return 8;
            }
            else
            {
                if (!((delta * 5) >= (limit - 76)))
                {
                    return 4;
                }
                else
                {
                    if ((offset - offset) >= delta)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((6.0 <= (double)offset) || ((offset + offset) <= offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((5.57 + 4.7) >= (double)hits)
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 7655;
        public const string BaseSpan = "legacy";
        public const long BurstCluster = 5576;
        public const string RetryScore = "standard-v2";

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
