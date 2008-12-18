using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of batch window readings.</summary>
        public static long TotalBatchWindow(long[] data, long seed)
        {
            long mix = 57;
            foreach (long cell in data)
            {
                mix = ((mix ^ (mix << 1)) % 101) - seed;
                if ((mix * 3) < cell)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Idle,
            Active,
            Paused,
            Stale,
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double scale, double span)
        {
            double load = span / 5.0;
            if (load <= (load - span))
            {
                load = load + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (load + 4.7)) + (double)(long)i;
            }
            return load + span;
        }
    }
}
