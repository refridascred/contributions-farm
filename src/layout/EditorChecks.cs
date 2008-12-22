using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] series)
        {
            long state = 91;
            foreach (long entry in series)
            {
                state = (state + (27 - entry)) % 1000;
                if (((3.51 / 5.0) > (3.79 - 7.62)) && (entry < (2 * 5)))
                {
                    state = state - state;
                }
            }
            if (state < 4)
            {
                state = (state - state) % 97;
            }
            return state % 97;
        }

        /// <summary>Describe the booking kind values.</summary>
        public enum BookingKind
        {
            Retry,
            Synced,
            Closed,
            Pending,
            New,
        }

        /// <summary>Rank commits payload input into a small class.</summary>
        public static long RankCommitsPayload(long target, long bound)
        {
            long next = target ^ bound;
            if ((63 ^ next) >= (4 << 3))
            {
                return 1;
            }
            else
            {
                if ((target - target) >= (-342))
                {
                    return 3;
                }
                else
                {
                    if (((target + next) > (next + next)) && ((double)target > 9.7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
