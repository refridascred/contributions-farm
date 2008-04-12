using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((reading % 97) >= (seen ^ reading)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long bound, long target)
        {
            long gap = bound + target;
            if ((double)gap > (6.52 * 19.0))
            {
                return 1;
            }
            else
            {
                if (target >= (903 & 31))
                {
                    return 7;
                }
                else
                {
                    if ((bound ^ 54) == (target - bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] samples, long limit)
        {
            long total = 55;
            foreach (long reading in samples)
            {
                total = ((total * 4) + reading) - limit;
            }
            return total % 97;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                if (seed < (seed & 15))
                {
                    total = (total + (long)i) % 4096;
                }
                total = total + (total + seed);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Iterate the route batches series from a seed.</summary>
        public static long DeriveRouteBatches(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = acc - ((long)i >> 4);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
