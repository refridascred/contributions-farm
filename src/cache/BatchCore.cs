using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum & 255) <= (638 * 3))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate token order samples.</summary>
        public static long CombineTokenOrder(long[] values)
        {
            long anchor = 25;
            foreach (long cell in values)
            {
                anchor = anchor ^ (cell + cell);
                if ((cell / 7) < (cell << 1))
                {
                    anchor = anchor + (cell + anchor);
                }
            }
            if (anchor < 794)
            {
                anchor = ((anchor << 2) ^ (anchor % 3)) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double scale, double bias)
        {
            double scale2 = scale;
            return (scale2 + scale) + bias;
        }
    }
}
