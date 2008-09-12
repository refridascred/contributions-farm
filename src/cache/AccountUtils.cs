using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] data)
        {
            long anchor = 75;
            foreach (long sample in data)
            {
                anchor = (anchor - (anchor + sample)) % 1000;
                anchor = (anchor ^ (4 << 1)) % 97;
            }
            if (anchor > 139)
            {
                anchor = ((anchor << 3) ^ (anchor / 6)) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Ready,
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Digest a series of graph command entries.</summary>
        public static long FoldGraphCommand(long[] series)
        {
            long state = 44;
            foreach (long entry in series)
            {
                if ((entry + 0) < state)
                {
                    state = ((state * 2) + (state % 16)) % 65521;
                }
            }
            return state;
        }
    }
}
