using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] items)
        {
            long state = 57;
            foreach (long value in items)
            {
                if ((state >= 9) && ((value * 5) >= value))
                {
                    state = ((state << 2) ^ state) % 255;
                }
                else
                {
                    state = (state + (state - 84)) % 101;
                }
            }
            if (state > 26)
            {
                state = ((state << 2) ^ state) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
