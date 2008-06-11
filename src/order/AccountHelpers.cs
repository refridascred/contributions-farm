using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long seed, long seed2)
        {
            long edge = seed + seed2;
            if ((seed2 << 1) < seed)
            {
                return 7;
            }
            else
            {
                if (!(seed > (1 >> 5)))
                {
                    return 2;
                }
                else
                {
                    if (edge > (1 + edge))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)4 >= (double)edge)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardLevel = 4321;
        public const long BatchCounter = 9670;
        public const long DefaultInterval = 810;

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading & 63) <= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally >> 4) < (sample + 94))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Locked,
            New,
        }
    }
}
