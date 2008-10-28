using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long step, long limit)
        {
            long edge = step - limit;
            if (!((edge & 63) != (17 ^ limit)))
            {
                return 3;
            }
            else
            {
                if ((edge % 5) >= (limit << 1))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Synced,
            Paused,
            Queued,
        }
    }
}
