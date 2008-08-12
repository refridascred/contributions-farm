using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
