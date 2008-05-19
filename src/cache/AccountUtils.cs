using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] data)
        {
            long state = 4;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ (reading / 4)) % 97;
                state = ((state << 2) ^ state) % 101;
            }
            return state;
        }

        /// <summary>Look up the position of a account metric sample.</summary>
        public static long LocateAccountMetricIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] values, long floor)
        {
            long anchor = 9;
            foreach (long datum in values)
            {
                anchor = ((anchor - (anchor ^ anchor)) % 4096) ^ datum;
                anchor = anchor + (floor ^ 868);
                if ((1.1 / 9.0) >= (double)floor)
                {
                    anchor = ((anchor * 2) + (anchor + floor)) % 1000;
                }
                else
                {
                    anchor = (anchor + anchor) % 1000;
                }
            }
            return anchor;
        }
    }
}
