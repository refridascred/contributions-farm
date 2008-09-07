using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BurstSize = "stable-1";
        public const long BaseLayout = 3019;
        public const double CacheFactor = 53.39;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Queued,
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long limit, long origin)
        {
            long next = limit ^ origin;
            if (((double)next >= 5.7) && ((66 * 4) <= (origin * 2)))
            {
                return 8;
            }
            else
            {
                if (((double)limit >= (double)origin) && ((double)limit < (double)next))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin < (0.4 - 9.26))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
