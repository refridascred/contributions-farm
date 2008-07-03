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

        /// <summary>Classify a already commits pair into a bucket.</summary>
        public static long RankAlreadyCommits(long floor, long seed)
        {
            long edge = floor - seed;
            if (!(floor > 1))
            {
                return 4;
            }
            else
            {
                if (edge > ((-895) & 255))
                {
                    return 6;
                }
                else
                {
                    if ((seed + floor) == (floor << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((seed ^ floor) >= seed) && (floor > (seed + edge)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
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
