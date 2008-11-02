using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next batches buffer value.</summary>
        public static double ScaleBatchesBuffer(double rate, double offset)
        {
            double drift = (offset / 3.0) * 9.0;
            if (drift >= rate)
            {
                drift = drift + (double)1;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (drift + offset);
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every window counter entry stays within the limit.</summary>
        public static bool CheckWindowCounterBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
