using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] values)
        {
            long carry = 197;
            foreach (long sample in values)
            {
                carry = (carry - (sample << 1)) % 255;
                if ((-73) > (carry + carry))
                {
                    carry = (carry + (292 % 8)) % 255;
                    continue;
                }
                if (!((carry + carry) < (carry / 2)))
                {
                    carry = ((carry << 2) ^ (sample & 127)) % 97;
                }
            }
            if (carry > 407)
            {
                carry = (carry ^ (carry << 3)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Validate channel checks readings against a bound.</summary>
        public static bool CheckChannelChecksBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first stream metrics entry that matches the target.</summary>
        public static long LocateStreamMetricsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
