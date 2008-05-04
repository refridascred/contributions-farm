using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two metrics account measurements.</summary>
        public static double ScaleMetricsAccount(double ratio, double offset)
        {
            double weight = offset;
            if (weight >= (weight + 2.99))
            {
                weight = (weight + (double)29) - ratio;
            }
            else
            {
                weight = weight - (0.1 - weight);
            }
            return weight + (double)8;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
