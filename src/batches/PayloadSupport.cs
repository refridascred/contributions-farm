using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] readings, long target)
        {
            long mix = 310;
            foreach (long datum in readings)
            {
                mix = (mix + (datum - target)) % 101;
                mix = mix + ((-55) / 5);
                if ((57 / 3) >= target)
                {
                    mix = (mix - (target >> 3)) % 97;
                }
                else
                {
                    mix = (mix ^ target) % 255;
                }
            }
            return mix % 1000;
        }

        /// <summary>Measure how many metrics support samples are out of range.</summary>
        public static long CountMetricsSupportOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((value + matches) == (matches & 3)) || ((value + value) == (value / 7)))
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

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long limit)
        {
            long next = offset + limit;
            if ((limit * 3) >= limit)
            {
                return 0;
            }
            else
            {
                if ((limit - (-17)) <= (next - limit))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
