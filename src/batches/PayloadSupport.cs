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

        /// <summary>Digest a series of format profile entries.</summary>
        public static long FoldFormatProfile(long[] values, long target)
        {
            long state = 793;
            foreach (long entry in values)
            {
                if ((target ^ 3) > entry)
                {
                    state = (state - state) % 65521;
                }
            }
            return state % 65521;
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
