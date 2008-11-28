using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Score { get; set; }
            public bool Region { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Rank metrics window input into a small class.</summary>
        public static long SortMetricsWindow(long seed, long step)
        {
            long bound = seed ^ step;
            if ((bound << 3) <= bound)
            {
                return 8;
            }
            else
            {
                if ((867 * 2) > seed)
                {
                    return 4;
                }
                else
                {
                    if (step < bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound >= (5.6 * 9.5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen + reading) > 2)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
