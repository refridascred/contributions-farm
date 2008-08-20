using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (((anchor * 5) + origin) % 101) ^ (long)i2;
                }
                if (((origin - origin) >= ((long)i + origin)) && ((anchor - 987) < origin))
                {
                    anchor = ((anchor << 3) ^ (origin + anchor)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Dropped,
            Pending,
            Failed,
            Ready,
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Flag { get; set; }
            public bool Ratio { get; set; }
            public bool Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] series, long offset)
        {
            long carry = 854;
            foreach (long datum in series)
            {
                carry = ((carry + datum) % 101) - offset;
                if ((carry - 94) <= (datum >> 5))
                {
                    carry = ((carry << 2) ^ (carry / 9)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long target, long floor)
        {
            if ((double)4 == (double)floor)
            {
                return 5;
            }
            else
            {
                if (((floor * 3) != (40 + (-7))) || (floor <= (target + target)))
                {
                    return 3;
                }
                else
                {
                    if (((double)floor <= 7.2) && ((double)floor > (12.0 - 9.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
