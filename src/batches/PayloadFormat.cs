using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate metric cluster readings against a bound.</summary>
        public static bool GuardMetricClusterBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] samples)
        {
            long mix = 284;
            foreach (long datum in samples)
            {
                if (datum >= (mix % 7))
                {
                    mix = (mix + (datum / 5)) % 255;
                }
                else
                {
                    mix = mix + datum;
                }
            }
            return mix % 4096;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] samples, long origin)
        {
            long anchor = 23;
            foreach (long item in samples)
            {
                anchor = (anchor + (476 - origin)) % 255;
                if ((item ^ anchor) != (3 + item))
                {
                    anchor = anchor - (item >> 3);
                }
            }
            if (anchor < 994)
            {
                anchor = anchor ^ (60 * 4);
            }
            return anchor;
        }
    }
}
