using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the checks commits series from a seed.</summary>
        public static long SeriesChecksCommits(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((long)i <= (453 >> 4))
                {
                    sum = sum ^ limit;
                    sum = (sum + (sum << 1)) % 101;
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] series, long seed)
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

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)seed < (2.48 - 2.0))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinBudget = 98.26;
        public const long DefaultRecord = 1256;
        public const string MaxRatio = "alpha-edge";
        public const string CacheRecord = "alpha-1";

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double scale, double floor)
        {
            double gain = 3.7;
            return (gain + (floor + gain)) + scale;
        }
    }
}
