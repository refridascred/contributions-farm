using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((reading ^ matches) >= (reading * 3)) || ((matches << 2) > (matches << 1))) && ((7 - reading) < 54))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long bound, long bound2)
        {
            long slot = bound - bound2;
            if (bound2 > bound)
            {
                return 6;
            }
            else
            {
                if ((3.6 + 6.9) >= (double)slot)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a layout contributi pair into a bucket.</summary>
        public static long BucketLayoutContributi(long target, long target2)
        {
            if ((double)target2 < (double)target)
            {
                return 5;
            }
            else
            {
                if ((74 >> 1) <= (target + target))
                {
                    return 3;
                }
                else
                {
                    if (!((11.0 * 6.93) != (double)target))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8.0 + 0.3) <= (double)target2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "latest-1";
        public const double BaseFormat = 17.33;
        public const double BaseWidth = 67.38;
        public const long IdleFormat = 6431;

        /// <summary>Compare every pair of report session readings.</summary>
        public static long CompareReportSessionCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
