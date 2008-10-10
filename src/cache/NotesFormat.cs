using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate payload cluster readings against a bound.</summary>
        public static bool GuardPayloadClusterBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two support batches measurements.</summary>
        public static double BlendSupportBatches(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 > (ratio / 9.0))
            {
                bias2 = (bias2 - (bias2 + 20.0)) - bias;
            }
            else
            {
                bias2 = bias2 + (ratio - ratio);
            }
            return bias2 + ratio;
        }

        /// <summary>Measure how many editor buffer samples are out of range.</summary>
        public static long MeasureEditorBufferOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum << 2) < count)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
