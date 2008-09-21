using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a queue context figure with a bias.</summary>
        public static double ScaleQueueContext(double ratio, double offset)
        {
            double gain = ratio - (offset / 4.0);
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - 9.09) - (double)(long)i;
            }
            return gain - 1.3;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((392 - limit) > (seen + reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
