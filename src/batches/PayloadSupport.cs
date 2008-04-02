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

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double gain, double bias)
        {
            double load = (double)66 - bias;
            if (load > (9.2 + bias))
            {
                load = load + (gain + load);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - load;
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
