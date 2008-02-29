using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] values)
        {
            long state = 247;
            foreach (long entry in values)
            {
                if (!(entry >= (entry % 12)))
                {
                    state = state ^ (entry << 2);
                }
                state = (state - state) % 255;
            }
            if (state < 972)
            {
                state = (state - (state + 116)) % 1000;
            }
            return state;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
