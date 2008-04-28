using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next cluster profile value from a seed.</summary>
        public static long SeriesClusterProfile(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = result + (result + 170);
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a layout channel pair into a bucket.</summary>
        public static long ClassifyLayoutChannel(long bound, long step)
        {
            if ((0.3 >= (double)step) || ((double)2 > (double)bound))
            {
                return 4;
            }
            else
            {
                if ((double)step < 0.42)
                {
                    return 6;
                }
                else
                {
                    if ((bound * 2) > step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound >> 5) >= bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryMetrics = 1.06;
        public const long WindowMetrics = 7770;
        public const string StepMetrics = "strict-1";
        public const long RetryFactor = 5131;

        /// <summary>Combine context contributi values into a single score.</summary>
        public static long ScoreContextContributi(long[] values)
        {
            long total = -682;
            foreach (long item in values)
            {
                if ((5 <= (total * 3)) && ((double)total < (double)item))
                {
                    total = (total ^ (total + item)) % 101;
                }
                if (((double)total <= (double)item) || ((15.0 / 8.0) == (double)item))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + count) < (20 + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
