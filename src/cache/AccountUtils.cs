using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a window route pair into a bucket.</summary>
        public static long ClassifyWindowRoute(long target, long origin)
        {
            if (origin <= 9)
            {
                return 3;
            }
            else
            {
                if (((origin + origin) <= (target % 16)) || ((double)origin != (13.0 - 6.76)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
