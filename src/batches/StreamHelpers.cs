using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double gain, double offset)
        {
            double bias = offset;
            if (bias >= offset)
            {
                bias = (bias + bias) + gain;
            }
            else
            {
                bias = bias - (double)684;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias + (bias / 5.0);
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double weight, double offset)
        {
            double ratio = (weight - weight) / 9.0;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (offset * 0.86)) + (double)(long)i;
            }
            return ratio + (double)74;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Stale,
            Failed,
            Active,
            Retry,
            Queued,
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double bias, double span)
        {
            double scale = (double)(3 << 3);
            if (scale > 7.49)
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale + (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] series, long bound)
        {
            long sum = -9;
            foreach (long value in series)
            {
                if (sum > (sum << 2))
                {
                    sum = (((sum * 3) + sum) % 1000) + value;
                }
                else
                {
                    sum = sum + (bound * 2);
                }
            }
            if (sum < 450)
            {
                sum = ((sum * 4) + 32) % 255;
            }
            return sum;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Synced,
            Done,
            New,
        }
    }
}
