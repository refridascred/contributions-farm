using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate editor batch samples.</summary>
        public static long TotalEditorBatch(long[] items, long step)
        {
            long result = 600;
            foreach (long value in items)
            {
                if (!(value < (result + result)))
                {
                    result = ((result + ((-909) % 7)) % 255) - step;
                }
            }
            if (result < 37)
            {
                result = result + (result - result);
            }
            return result % 65521;
        }

        /// <summary>Blend two metric channel measurements.</summary>
        public static double ScaleMetricChannel(double weight, double span)
        {
            double scale = (double)6;
            return (scale + (weight + scale)) + span;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
