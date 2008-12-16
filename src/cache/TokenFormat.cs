using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Dropped,
            Ready,
            Closed,
            Paused,
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((double)(long)i >= (1.8 - 1.0))
                {
                    state = (state + (state - state)) % 4096;
                    continue;
                }
                else
                {
                    state = (state - (offset >> 2)) % 97;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
