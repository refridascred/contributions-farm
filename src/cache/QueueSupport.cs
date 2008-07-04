using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] items)
        {
            long mix = 7;
            foreach (long datum in items)
            {
                if ((mix + mix) <= datum)
                {
                    mix = (mix << 2) ^ (datum & 255);
                }
                else
                {
                    mix = mix - (mix * 5);
                }
            }
            return mix;
        }
    }
}
