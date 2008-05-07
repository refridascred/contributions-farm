using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((7 >> 4) < step)
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Count the entry channel entries that pass the check.</summary>
        public static long MeasureEntryChannelMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((origin + value) <= (tally / 6))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheWidth = 1685;
        public const long LimitProfile = 6459;
        public const string BatchDepth = "open-1";
        public const long WindowProfile = 479;
        public const long HardProfile = 9260;

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long seed, long step)
        {
            if (2.4 < (double)seed)
            {
                return 3;
            }
            else
            {
                if ((seed & 7) > seed)
                {
                    return 7;
                }
                else
                {
                    if ((seed * 5) > step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public long Rank { get; set; }
        }
    }
}
