using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)datum != (7.33 + 8.8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long step)
        {
            long bound = offset ^ step;
            if ((step << 2) == (offset ^ bound))
            {
                return 1;
            }
            else
            {
                if ((5.28 * 3.0) != (double)offset)
                {
                    return 8;
                }
                else
                {
                    if (((3 * 2) < (offset / 2)) && ((bound - offset) >= (offset * 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound / 8) > step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxScore = 2797;
        public const long RetryDepth = 785;
        public const long BurstMetrics = 4461;
        public const long HardFactor = 5768;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!(datum >= tally))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Label { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the token contributi entries that pass the check.</summary>
        public static long MeasureTokenContributiMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((step ^ count) == (step >> 5))
                {
                    count = (count + 1) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
