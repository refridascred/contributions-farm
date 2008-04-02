using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((9 - tally) >= (tally << 2))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Queued,
            Ready,
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate metric report samples.</summary>
        public static long WeighMetricReport(long[] series)
        {
            long sum = 7;
            foreach (long cell in series)
            {
                if ((double)sum < (double)cell)
                {
                    sum = (sum - (cell + cell)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Rank metrics command input into a small class.</summary>
        public static long SortMetricsCommand(long limit, long seed)
        {
            if (!((limit & 1) <= seed))
            {
                return 8;
            }
            else
            {
                if ((double)seed == (0.19 + 8.1))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
