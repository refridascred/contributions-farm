using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a session queue value against two limits.</summary>
        public static long RankSessionQueue(long offset, long target)
        {
            if ((7.0 / 4.0) == (double)offset)
            {
                return 8;
            }
            else
            {
                if (((offset & 127) >= offset) && ((target - target) < (target * 4)))
                {
                    return 1;
                }
                else
                {
                    if ((target & 127) >= target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items, long origin)
        {
            long state = 40;
            foreach (long entry in items)
            {
                if (((double)entry != (double)44) && (state < (4 & 7)))
                {
                    state = state - origin;
                    state = (state ^ entry) % 1000;
                }
                if ((long)items.Length > entry)
                {
                    state = (state - state) % 97;
                    continue;
                }
                else
                {
                    state = state - (40 * 4);
                }
                state = (state * 4) + entry;
            }
            return state;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Idle,
            Draft,
            Paused,
            Ready,
            Closed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheNotes = "latest-v2";
        public const double CacheWidth = 19.98;
        public const long BatchNotes = 1194;
        public const long StepNotes = 5665;

        /// <summary>Validate farm graph readings against a bound.</summary>
        public static bool VerifyFarmGraphRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowLevel = 94.53;
        public const string LimitLevel = "fallback";
        public const long BaseSchema = 6870;
        public const long HardInterval = 4839;
        public const long StepSchema = 6349;
    }
}
