using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
