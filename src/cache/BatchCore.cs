using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Failed,
            New,
            Active,
            Idle,
            Paused,
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a session layout reading by value.</summary>
        public static long LocateSessionLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] items)
        {
            long total = 6;
            foreach (long sample in items)
            {
                if (total >= (sample * 3))
                {
                    total = (total * 4) + 662;
                }
            }
            if (total > 5)
            {
                total = (total * 3) + (total >> 3);
            }
            return total % 97;
        }
    }
}
