using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + offset) >= (reading >> 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double rate, double offset)
        {
            double ratio = offset;
            if (ratio <= 8.74)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double bias, double span)
        {
            double drift = (bias + bias) / 9.0;
            if (drift > 9.32)
            {
                drift = (drift + 3.44) + span;
            }
            else
            {
                drift = drift + 4.4;
            }
            return drift + bias;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
