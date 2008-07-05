using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)bound < (0.97 + 6.0))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double ratio, double span)
        {
            double drift = 8.3;
            if (drift >= (1.0 * 13.0))
            {
                drift = drift - span;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (ratio * 5.99)) + (double)(long)i;
            }
            return drift + (drift - ratio);
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (matches >= (matches ^ sample))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long offset)
        {
            long result = offset;
            for (int i = 0; i < 20; i++)
            {
                result = (result + (result - (long)i)) % 97;
                if ((result / 3) >= offset)
                {
                    result = (result - (result / 3)) % 101;
                    result = result + offset;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result + (long)i) % 255) ^ (long)i2;
                    result = ((result << 3) ^ (offset / 3)) % 1000;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] levels)
        {
            long total = 726;
            foreach (long value in levels)
            {
                if (!(total <= (value % 24)))
                {
                    total = total + total;
                }
                total = (total ^ (value & 1)) % 97;
            }
            return total % 97;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample % 16) != (sample >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
