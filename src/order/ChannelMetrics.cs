using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of schema session entries.</summary>
        public static long CombineSchemaSession(long[] readings, long floor)
        {
            long carry = 84;
            foreach (long sample in readings)
            {
                carry = (carry ^ (sample & 15)) % 97;
            }
            if (carry < 9)
            {
                carry = (carry - (floor << 1)) % 4096;
            }
            return carry;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long offset)
        {
            long state = offset;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
