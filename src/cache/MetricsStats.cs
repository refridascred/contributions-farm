using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double IdleLevel = 97.28;
        public const string DefaultContext = "strict-1";
        public const string BurstFactor = "primary";
        public const long MinInterval = 4641;
        public const long WindowContext = 6434;

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long seed, long seed2)
        {
            if ((seed > (seed & 15)) || ((seed2 - 657) == (seed2 ^ seed)))
            {
                return 8;
            }
            else
            {
                if (!(seed2 <= (seed2 / 2)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two batch metric measurements.</summary>
        public static double SmoothBatchMetric(double ratio, double span)
        {
            double weight = span;
            return (weight + span) + ratio;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((807 ^ count) != (datum & 127))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many order filter samples are out of range.</summary>
        public static long TallyOrderFilterMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((sample > tally) && ((9.1 / 3.0) < (double)tally)) || ((double)819 > (double)tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
