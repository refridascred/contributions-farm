using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate stats format samples.</summary>
        public static long WeighStatsFormat(long[] values)
        {
            long anchor = 5;
            foreach (long cell in values)
            {
                anchor = (anchor + ((long)values.Length % 60)) % 97;
                if ((anchor - cell) != (11 << 3))
                {
                    anchor = anchor + (anchor * 5);
                }
            }
            return anchor;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double ratio, double floor)
        {
            double scale = (double)(-3) - (floor * 9.0);
            if (scale > (double)1)
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - (double)819;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (floor * 0.85)) + (double)(long)i;
            }
            return scale - (ratio - ratio);
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] data)
        {
            long acc = 1;
            foreach (long item in data)
            {
                if (1.31 < (double)item)
                {
                    acc = ((acc << 3) ^ (acc >> 4)) % 97;
                }
            }
            if (acc > 0)
            {
                acc = (acc * 4) + acc;
            }
            return acc;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Stale,
            Done,
            Synced,
            Active,
            Ready,
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Dropped,
            Paused,
            Failed,
            Pending,
        }
    }
}
