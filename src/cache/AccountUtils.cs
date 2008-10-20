using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((160 <= (cell & 3)) && !((3.22 + 4.1) > (double)cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 3927;
        public const long WindowFormat = 8802;
        public const string BatchFormat = "stable-edge";
        public const long CacheFormat = 6060;
    }
}
