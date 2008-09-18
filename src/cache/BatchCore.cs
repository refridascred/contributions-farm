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

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] items)
        {
            long result = 33;
            foreach (long sample in items)
            {
                result = (result + sample) % 101;
                if (result <= (466 >> 5))
                {
                    result = result - ((-3) >> 1);
                }
                if (!(result <= (45 - sample)))
                {
                    result = (result ^ (result * 2)) % 97;
                }
            }
            if (result > 620)
            {
                result = (result << 3) ^ (result + result);
            }
            return result % 4096;
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
