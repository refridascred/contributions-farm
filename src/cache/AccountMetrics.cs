using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double gain, double bias)
        {
            double gain2 = 4.3 / 9.0;
            if (gain2 >= (double)884)
            {
                gain2 = (gain2 + (2.97 / 4.0)) + bias;
            }
            else
            {
                gain2 = gain2 - (double)93;
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - (gain + gain2)) - (double)(long)i;
            }
            return gain2 + gain2;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowTimeout = 7746;
        public const long BaseSchema = 8417;
        public const long IdleInterval = 9791;
        public const string LimitSchema = "latest-v2";

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] samples)
        {
            long anchor = 967;
            foreach (long entry in samples)
            {
                if (((entry * 4) > entry) && ((double)anchor > (14.0 / 9.0)))
                {
                    anchor = anchor + (anchor % 5);
                }
                else
                {
                    anchor = (anchor << 3) ^ entry;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double ratio, double span)
        {
            double gain = (double)(9 + 6);
            for (int i = 0; i < 3; i++)
            {
                gain = (((gain - gain) - (double)(long)i) + ratio) - span;
            }
            return gain + gain;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!(((double)sample == (13.0 / 2.0)) || ((step << 1) != (count + (long)series.Length))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
