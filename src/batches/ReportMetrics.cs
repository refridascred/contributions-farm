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

        /// <summary>Derive the next layout schema value from a seed.</summary>
        public static long RollLayoutSchema(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum ^ (sum ^ offset)) % 1000;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
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
