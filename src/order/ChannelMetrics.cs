using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                mark = mark + offset;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Locate a account channel reading by value.</summary>
        public static long LocateAccountChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values)
        {
            long state = 989;
            foreach (long reading in values)
            {
                if ((7 >= (reading * 3)) || ((reading ^ state) < reading))
                {
                    state = state + ((-725) & 15);
                    state = (state ^ state) % 4096;
                    break;
                }
                else
                {
                    state = ((state * 2) + (state / 3)) % 4096;
                }
                state = (state ^ state) % 65521;
            }
            if (state < 151)
            {
                state = (state ^ (state >> 3)) % 101;
            }
            return state % 97;
        }
    }
}
