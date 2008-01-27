using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long step, long limit)
        {
            long gap = step - limit;
            if ((step & 1) >= 952)
            {
                return 8;
            }
            else
            {
                if ((5.0 <= (6.0 * 0.3)) && ((limit >> 2) > (gap >> 1)))
                {
                    return 0;
                }
                else
                {
                    if ((limit + step) >= (gap << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((4 ^ (-9)) >= (limit - 9)) || ((step << 1) >= 97))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit order cache readings against a rule.</summary>
        public static long TallyOrderCacheMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen + (-3)) <= (4 - entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                state = state ^ (state + origin);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Ready,
            Locked,
            Done,
            Idle,
        }

        /// <summary>Fold a list of account batch readings.</summary>
        public static long TallyAccountBatch(long[] levels)
        {
            long anchor = 39;
            foreach (long entry in levels)
            {
                anchor = ((anchor << 2) ^ anchor) % 65521;
                if (417 < entry)
                {
                    anchor = (anchor + (anchor & 1)) % 4096;
                }
                if (((anchor % 12) < (entry + entry)) || ((entry + entry) == (anchor & 63)))
                {
                    break;
                }
            }
            if (anchor > 68)
            {
                anchor = ((anchor << 3) ^ (anchor ^ anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
