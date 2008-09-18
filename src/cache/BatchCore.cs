using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double ratio, double floor)
        {
            double bias = ratio * 3.14;
            if (bias >= (ratio * 3.28))
            {
                bias = (bias + (ratio + bias)) - floor;
            }
            else
            {
                bias = bias - (ratio * 3.7);
            }
            return bias + (ratio / 5.0);
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits ^ step) == (datum & 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every channel context entry stays within the limit.</summary>
        public static bool VerifyChannelContextLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every record channel entry stays within the limit.</summary>
        public static bool CheckRecordChannelLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
