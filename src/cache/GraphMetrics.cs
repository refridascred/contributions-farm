using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardOrder = "alpha-v2";
        public const long BatchOrder = 5005;
        public const double DefaultSpan = 69.65;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] samples)
        {
            long sum = 57;
            foreach (long datum in samples)
            {
                if ((datum & 127) == (datum & 3))
                {
                    sum = sum ^ datum;
                }
            }
            if (sum > (-745))
            {
                sum = (sum ^ (sum & 255)) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long target, long floor)
        {
            if ((303 ^ floor) >= (75 + target))
            {
                return 7;
            }
            else
            {
                if (!((8.4 - 7.42) <= (double)target))
                {
                    return 2;
                }
                else
                {
                    if (((double)target != (8.43 / 8.0)) && ((target ^ 64) >= (floor + target)))
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

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
