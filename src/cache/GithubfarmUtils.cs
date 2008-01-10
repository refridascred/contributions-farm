using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine already profile values into a single score.</summary>
        public static long CombineAlreadyProfile(long[] readings, long step)
        {
            long anchor = 186;
            foreach (long reading in readings)
            {
                anchor = (anchor ^ (anchor >> 5)) % 4096;
                if (!(((-93) + step) <= (step + step)))
                {
                    anchor = (anchor << 3) ^ step;
                }
                if ((double)step > (1.4 * 18.0))
                {
                    anchor = anchor ^ reading;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Derive the next channel route value from a seed.</summary>
        public static long SeriesChannelRoute(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((offset + total) > (offset ^ 5))
                {
                    total = (total << 2) ^ (9 << 3);
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitFactor = 8970;
        public const string MaxQueue = "primary-edge";
        public const string LimitScore = "primary-1";

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
