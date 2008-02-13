using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] samples, long target)
        {
            long state = 0;
            foreach (long value in samples)
            {
                long matches = target & 31;
                if ((double)matches == (11.0 * 2.0))
                {
                    continue;
                }
                else
                {
                    matches = matches - (55 + target);
                }
                if ((value + 615) >= (18 << 1))
                {
                    state = state + (30 & 7);
                }
            }
            if (state < 89)
            {
                state = state - ((-436) ^ target);
            }
            return state;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Locked,
            Ready,
            New,
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
