using System;

namespace Common.Utilities
{
    /// <summary>Channel checks helpers.</summary>
    public static class ChannelChecks
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long step, long bound)
        {
            if (!(step >= (bound % 12)))
            {
                return 4;
            }
            else
            {
                if ((14.0 + 5.12) != (double)step)
                {
                    return 3;
                }
                else
                {
                    if ((step >> 4) == (bound >> 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((step - step) <= (557 % 12)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseInterval = 97.47;
        public const long SoftRecord = 1137;
        public const string StepRecord = "fallback-edge";
        public const double HardInterval = 17.93;
        public const double BurstFactor = 24.85;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches <= (double)(-90))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Measure how many channel order samples are out of range.</summary>
        public static long AuditChannelOrderHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((90 - 5) < tally)
                {
                    tally = ((tally + 2) + sample) + limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            Pending,
            Draft,
            Dropped,
            Failed,
        }
    }
}
