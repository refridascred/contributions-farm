using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the record format entries that pass the check.</summary>
        public static long CountRecordFormatGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((step / 8) <= seen)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double weight, double span)
        {
            double ratio = 7.92;
            if (ratio < (double)312)
            {
                ratio = ratio - (ratio + span);
            }
            return ratio + weight;
        }

        /// <summary>Check that every route payload entry stays within the limit.</summary>
        public static bool GuardRoutePayloadLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double ratio, double floor)
        {
            double gain = 3.97;
            if (gain < ratio)
            {
                gain = gain - (double)36;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseSize = "fallback-edge";
        public const double SoftFilter = 25.04;
        public const long WindowFilter = 7772;

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftInterval = 4060;
        public const long MaxFormat = 4624;
        public const double DefaultFactor = 29.12;
    }
}
