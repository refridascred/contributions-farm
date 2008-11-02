using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Pending,
            Idle,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                long prev = (target + (long)i) << 1;
                sum = sum + (target - prev);
                sum = (sum + ((long)i >> 5)) % 1000;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Fold a list of token window readings.</summary>
        public static long WeighTokenWindow(long[] readings, long offset)
        {
            long state = 525;
            foreach (long cell in readings)
            {
                state = state + (cell & 31);
                if ((416 * 4) <= (state + cell))
                {
                    state = state - cell;
                }
                else
                {
                    state = (state + state) % 4096;
                }
                if (((double)state >= (double)cell) || ((41 ^ state) < (offset / 9)))
                {
                    break;
                }
            }
            return state;
        }
    }
}
