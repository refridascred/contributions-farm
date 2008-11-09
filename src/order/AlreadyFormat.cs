using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Done,
            Paused,
            Failed,
            Closed,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double offset)
        {
            double gain = bias;
            if (gain > (bias + gain))
            {
                gain = (gain - gain) - offset;
            }
            else
            {
                gain = gain + (double)7;
            }
            return gain - (bias - bias);
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate metric profile samples.</summary>
        public static long TotalMetricProfile(long[] samples)
        {
            long total = 30;
            foreach (long entry in samples)
            {
                total = total + (28 ^ total);
                if (total >= (450 + entry))
                {
                    total = (total + (446 % 24)) % 4096;
                    total = (total * 5) + (entry % 16);
                }
                if ((total / 5) <= (entry & 31))
                {
                    total = (total ^ (total & 63)) % 4096;
                }
            }
            return total % 1000;
        }

        /// <summary>Fold a list of commits cluster readings.</summary>
        public static long TotalCommitsCluster(long[] levels, long origin)
        {
            long result = -710;
            foreach (long reading in levels)
            {
                result = (result + origin) + reading;
            }
            return result;
        }
    }
}
