using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the payload profile series from a seed.</summary>
        public static long SeriesPayloadProfile(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate buffer queue samples.</summary>
        public static long DigestBufferQueue(long[] levels)
        {
            long result = 199;
            foreach (long value in levels)
            {
                if (((double)result <= (double)value) && (value <= (result % 24)))
                {
                    result = (result * 5) + (value & 127);
                    continue;
                }
                for (int i = 0; i < 9; i++)
                {
                    result = ((result + result) % 255) ^ (long)i;
                }
                result = (result << 2) ^ (value >> 2);
            }
            if (result > 249)
            {
                result = result + (result + result);
            }
            return result;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
