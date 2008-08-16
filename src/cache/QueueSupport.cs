using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] data, long step)
        {
            long mark = 60;
            foreach (long item in data)
            {
                if ((583 ^ item) < item)
                {
                    mark = ((mark + item) % 101) - step;
                }
            }
            return mark % 97;
        }

        /// <summary>Validate notes counter readings against a bound.</summary>
        public static bool CheckNotesCounterBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 7079;
        public const string SoftWidth = "stable-v2";
        public const long BaseStats = 477;
        public const long RetryTimeout = 2632;
    }
}
