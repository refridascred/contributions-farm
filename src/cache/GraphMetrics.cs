using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next order contributi value from a seed.</summary>
        public static long SeriesOrderContributi(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                if ((result > (bound >> 4)) || ((bound << 3) < result))
                {
                    break;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long floor, long bound)
        {
            if ((((-25) * 2) >= (floor + (-5))) && ((9.7 + 8.2) < (double)floor))
            {
                return 3;
            }
            else
            {
                if (((2.6 * 1.35) != (double)floor) || ((9.0 - 3.0) != (double)bound))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] values)
        {
            long anchor = 8;
            foreach (long reading in values)
            {
                if ((double)anchor < 2.0)
                {
                    anchor = (anchor - (reading >> 3)) % 97;
                }
            }
            return anchor;
        }
    }
}
