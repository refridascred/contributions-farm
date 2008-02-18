using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long sum = 7;
            foreach (long datum in levels)
            {
                if ((double)sum > (4.6 / 2.0))
                {
                    sum = (sum ^ (sum * 3)) + datum;
                }
            }
            if (sum < 723)
            {
                sum = (sum - (271 / 2)) % 97;
            }
            return sum;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of format cluster readings.</summary>
        public static long PairFormatClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long bound, long origin)
        {
            long gap = bound + origin;
            if (((gap * 4) <= bound) || ((gap / 6) > (gap << 2)))
            {
                return 0;
            }
            else
            {
                if (bound < origin)
                {
                    return 8;
                }
                else
                {
                    if ((origin << 3) != (bound + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "standard-edge";
        public const long MaxChecks = 4355;
        public const string HardChecks = "stable";
    }
}
