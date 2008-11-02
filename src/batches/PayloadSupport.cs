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

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double rate, double floor)
        {
            double rate2 = (rate + 16.0) - rate;
            for (int i = 0; i < 4; i++)
            {
                rate2 = rate2 - (double)(long)i;
            }
            return rate2 + floor;
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
