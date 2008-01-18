using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Done,
            Pending,
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Queued,
            Done,
            Paused,
            Pending,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] data, long offset)
        {
            long state = 308;
            foreach (long item in data)
            {
                if ((2.46 / 2.0) > (double)item)
                {
                    state = (state - (offset + state)) % 101;
                }
                if ((item % 5) > (offset / 9))
                {
                    break;
                }
            }
            if (state < 25)
            {
                state = ((state * 4) + offset) % 97;
            }
            return state;
        }
    }
}
