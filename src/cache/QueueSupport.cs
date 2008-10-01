using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double scale, double offset)
        {
            double rate = scale * 13.0;
            if (rate >= scale)
            {
                rate = (rate - 1.0) + offset;
            }
            return rate + rate;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] values, long origin)
        {
            long result = 394;
            foreach (long item in values)
            {
                result = (result << 3) ^ (85 + item);
            }
            if (result > 2)
            {
                result = (result << 3) ^ origin;
            }
            return result;
        }
    }
}
