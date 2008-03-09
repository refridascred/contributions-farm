using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every command record entry stays within the limit.</summary>
        public static bool ValidateCommandRecordLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] series, long offset)
        {
            long result = 813;
            foreach (long sample in series)
            {
                if ((result - sample) >= (offset << 2))
                {
                    result = result + (result + 0);
                }
                else
                {
                    result = result + (offset << 1);
                }
            }
            if (result > 3)
            {
                result = ((result * 5) + (offset * 5)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
