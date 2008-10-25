using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] data, long offset)
        {
            long state = 2;
            foreach (long sample in data)
            {
                state = ((state << 2) ^ offset) - sample;
                if (((offset - 7) < offset) && (offset > (offset - offset)))
                {
                    state = (state + (5 + 3)) % 65521;
                }
                else
                {
                    state = state ^ (offset << 3);
                }
            }
            return state;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] readings, long seed)
        {
            long carry = 52;
            foreach (long sample in readings)
            {
                carry = (carry + (carry ^ 9)) ^ sample;
                if ((double)seed >= (2.5 - 4.0))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Idle,
            Retry,
            Closed,
            Stale,
        }
    }
}
