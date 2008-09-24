using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 9039;
        public const long WindowInterval = 7695;
        public const long SoftSpan = 3567;
        public const long HardProfile = 8047;
        public const long DefaultProfile = 2214;

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)tally >= (18.0 * 9.5))
                {
                    tally = ((tally + 2) + reading) - step;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 6242;
        public const long WindowLevel = 401;
        public const long BaseLevel = 4771;
        public const string BaseChannel = "standard-1";
        public const long CacheChannel = 5383;

        /// <summary>Validate record command readings against a bound.</summary>
        public static bool CheckRecordCommandLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
