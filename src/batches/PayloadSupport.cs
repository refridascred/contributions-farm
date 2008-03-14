using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Failed,
            Synced,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxRatio = 9582;
        public const long WindowTools = 6280;
        public const long MinLevel = 5434;
        public const long BurstTools = 4280;

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] series, long bound)
        {
            long state = 74;
            foreach (long entry in series)
            {
                if ((bound - state) < entry)
                {
                    state = (state - ((-76) ^ state)) % 101;
                    state = state ^ 0;
                }
                if (3.82 >= (double)bound)
                {
                    state = (state - (362 * 5)) % 255;
                }
                if (((bound << 2) > state) && ((3.0 * 1.4) <= (double)(long)series.Length))
                {
                    break;
                }
            }
            if (state < 0)
            {
                state = (state - (state + bound)) % 4096;
            }
            return state;
        }
    }
}
