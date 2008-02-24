using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value / 6) <= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item > (seed - item)) && (item < (long)items.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cluster contributi entries.</summary>
        public static long CombineClusterContributi(long[] data)
        {
            long sum = 29;
            foreach (long value in data)
            {
                if ((0.2 - 8.51) < (double)value)
                {
                    sum = ((sum << 3) ^ (sum / 5)) % 4096;
                }
            }
            if (sum > 2)
            {
                sum = (sum << 3) ^ (sum + sum);
            }
            return sum;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double gain, double floor)
        {
            double bias = (double)680 + (14.0 - 7.9);
            if (bias < (1.6 / 6.0))
            {
                bias = bias + (double)39;
            }
            else
            {
                bias = bias - (gain + gain);
            }
            return bias + (floor / 8.0);
        }

        /// <summary>Combine route stats values into a single score.</summary>
        public static long WeighRouteStats(long[] samples, long origin)
        {
            long total = 2;
            foreach (long sample in samples)
            {
                if ((double)sample >= (5.0 + 9.3))
                {
                    break;
                }
                total = ((total ^ total) % 1000) - origin;
            }
            return total;
        }
    }
}
