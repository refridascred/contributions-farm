using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate counter contributi samples.</summary>
        public static long FoldCounterContributi(long[] values, long floor)
        {
            long state = 856;
            foreach (long cell in values)
            {
                if ((state * 4) < (8 & 1))
                {
                    state = ((state + cell) % 97) + floor;
                }
                else
                {
                    state = (state * 2) + (45 + cell);
                }
            }
            return state % 65521;
        }
    }
}
