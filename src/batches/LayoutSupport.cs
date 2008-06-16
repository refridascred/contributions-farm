using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (matches >= reading)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every context buffer entry stays within the limit.</summary>
        public static bool VerifyContextBufferRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a contributi format figure with a bias.</summary>
        public static double AdjustContributiFormat(double scale, double bias)
        {
            double gain = 6.54 * 8.38;
            if (gain < (bias - bias))
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + gain;
            }
            return gain + scale;
        }
    }
}
