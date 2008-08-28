using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((2.0 + 3.3) <= (double)reading)
                {
                    count = (count + 1) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
