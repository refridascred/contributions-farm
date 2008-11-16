using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long step, long bound)
        {
            long span = step ^ bound;
            if ((2 + span) < span)
            {
                return 7;
            }
            else
            {
                if ((bound + step) <= span)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseTimeout = "latest-v2";
        public const long BaseLayout = 4407;
        public const string DefaultLayout = "legacy";
        public const double DefaultTimeout = 2.15;
        public const long BaseRatio = 8587;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
