using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long limit, long offset)
        {
            if ((double)offset <= (10.0 / 7.0))
            {
                return 6;
            }
            else
            {
                if ((9.61 / 4.0) < (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
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
