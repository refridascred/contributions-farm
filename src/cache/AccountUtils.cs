using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((limit * 5) > (9 + matches))
                {
                    matches = (matches + 3) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
