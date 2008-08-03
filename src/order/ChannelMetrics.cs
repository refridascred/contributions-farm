using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the token cluster entries that pass the check.</summary>
        public static long CountTokenClusterGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)matches > (9.72 * 1.5))
                {
                    matches = ((matches + 1) ^ value) - step;
                }
            }
            return matches;
        }

        /// <summary>Accumulate route order samples.</summary>
        public static long WeighRouteOrder(long[] samples, long target)
        {
            long carry = 781;
            foreach (long item in samples)
            {
                carry = ((((carry << 3) ^ (carry % 10)) % 97) - item) - target;
                carry = (carry + (574 * 2)) % 4096;
            }
            if (carry > 117)
            {
                carry = (carry + ((long)samples.Length - (long)samples.Length)) % 4096;
            }
            return carry;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
