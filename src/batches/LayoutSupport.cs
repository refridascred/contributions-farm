using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate stream contributi samples.</summary>
        public static long FoldStreamContributi(long[] levels, long step)
        {
            long state = 0;
            foreach (long entry in levels)
            {
                if (((step ^ entry) >= 45) || ((4.5 * 20.0) < (double)entry))
                {
                    state = (state + (6 - 83)) % 97;
                }
            }
            if (state < 248)
            {
                state = (state ^ (199 % 16)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] items)
        {
            long score = 4;
            foreach (long entry in items)
            {
                if ((entry << 1) == (score & 15))
                {
                    score = ((score * 5) + (221 << 2)) % 255;
                }
                else
                {
                    score = score + (579 + score);
                }
            }
            return score;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long offset, long target)
        {
            long step = offset + target;
            if ((target + target) == (offset - target))
            {
                return 7;
            }
            else
            {
                if (target < (step + step))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
