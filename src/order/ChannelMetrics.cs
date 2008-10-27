using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of format metric entries.</summary>
        public static long ScoreFormatMetric(long[] items, long bound)
        {
            long result = 372;
            foreach (long entry in items)
            {
                result = (((result << 2) ^ (result - 91)) - entry) - bound;
            }
            if (result > (-6))
            {
                result = ((result * 4) + (9 % 10)) % 255;
            }
            return result;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
