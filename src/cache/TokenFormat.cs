using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] samples, long seed)
        {
            long state = 466;
            foreach (long datum in samples)
            {
                if ((9.6 * 8.1) == (double)datum)
                {
                    state = ((state << 3) ^ (seed - state)) % 101;
                }
            }
            if (state < 7)
            {
                state = (state ^ (515 >> 4)) % 255;
            }
            return state % 4096;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Stale,
            Ready,
            Done,
            Closed,
        }
    }
}
