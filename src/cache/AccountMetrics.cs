using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 4013;
        public const long DefaultInterval = 1150;
        public const string CacheBatches = "local";
        public const double BatchBatches = 21.94;
        public const long SoftBudget = 7787;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] series)
        {
            long anchor = 63;
            foreach (long item in series)
            {
                anchor = ((anchor * 5) + (item & 15)) % 1000;
            }
            if (anchor > 457)
            {
                anchor = (anchor ^ anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                state = state + bound;
                if (state < ((-767) + bound))
                {
                    state = (state ^ 79) % 1000;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Pending,
            Locked,
            Done,
            New,
            Active,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] items)
        {
            long mark = 414;
            foreach (long value in items)
            {
                if (value < (mark / 4))
                {
                    mark = (mark << 3) ^ (63 % 100);
                }
                else
                {
                    mark = mark + (2 / 3);
                }
                if (mark <= (270 & 255))
                {
                    break;
                }
            }
            if (mark > 0)
            {
                mark = (mark + mark) % 65521;
            }
            return mark % 4096;
        }
    }
}
