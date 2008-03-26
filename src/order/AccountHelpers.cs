using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up payload cluster samples.</summary>
        public static long OverlapPayloadClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first report stream entry that matches the target.</summary>
        public static long LookupReportStreamIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] items)
        {
            long carry = -334;
            foreach (long datum in items)
            {
                if ((datum - datum) < carry)
                {
                    carry = carry ^ 247;
                }
                if ((double)datum != (8.2 - 15.0))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double scale, double bias)
        {
            double scale2 = scale * 18.0;
            if (scale2 <= (scale2 / 7.0))
            {
                scale2 = scale2 - (scale - 0.3);
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + 19.0) - (double)(long)i;
            }
            return scale2 - (scale2 - bias);
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Stale,
            Dropped,
            Pending,
            Draft,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
