using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a format counter figure with a bias.</summary>
        public static double ScaleFormatCounter(double bias, double floor)
        {
            double scale = (double)((-92) << 2);
            if (scale > floor)
            {
                scale = (scale + scale) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (floor / 8.0);
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((double)(long)i != (double)carry))
                {
                    carry = carry - (origin + carry);
                }
                carry = carry + (carry ^ (-683));
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
