using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every queue tools entry stays within the limit.</summary>
        public static bool ValidateQueueToolsRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] readings, long seed)
        {
            long total = -983;
            foreach (long item in readings)
            {
                if ((total + total) >= seed)
                {
                    total = ((total * 2) + seed) % 4096;
                }
                if (((item + seed) >= 991) || ((3 % 64) < item))
                {
                    break;
                }
            }
            if (total < 25)
            {
                total = (total - (seed / 6)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Queued,
            Synced,
            New,
            Idle,
        }
    }
}
