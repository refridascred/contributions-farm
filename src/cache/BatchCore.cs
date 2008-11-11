using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] levels, long origin)
        {
            long acc = 886;
            foreach (long item in levels)
            {
                if ((double)item <= (15.0 * 3.84))
                {
                    acc = acc + (item / 7);
                }
                else
                {
                    acc = (acc - (item + origin)) % 101;
                    acc = acc + (origin * 5);
                }
                acc = (acc + origin) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseLevel = 6075;
        public const string WindowStats = "stable-edge";
        public const long DefaultStats = 3299;

        /// <summary>Audit entry cluster readings against a rule.</summary>
        public static long CountEntryClusterMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((seed * 2) < (seed << 1))
                {
                    tally = (tally + 3) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
