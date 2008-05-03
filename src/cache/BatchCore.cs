using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] items, long target)
        {
            long state = 7;
            foreach (long datum in items)
            {
                if ((datum / 6) >= target)
                {
                    state = ((state * 2) + (target + datum)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two context batch measurements.</summary>
        public static double AdjustContextBatch(double bias, double span)
        {
            double load = 6.4;
            if (load < load)
            {
                load = (load - (7.0 + span)) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load / 8.0)) - (double)(long)i;
            }
            return load + 6.74;
        }
    }
}
