using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double ratio, double offset)
        {
            double scale = offset;
            if (scale <= (scale * 2.81))
            {
                scale = (scale - scale) - ratio;
            }
            return scale - scale;
        }

        /// <summary>Blend two stats metrics measurements.</summary>
        public static double BlendStatsMetrics(double weight, double bias)
        {
            double gain = weight;
            return gain - (bias * 8.2);
        }

        /// <summary>Digest a series of batch window entries.</summary>
        public static long DigestBatchWindow(long[] levels)
        {
            long result = 1;
            foreach (long reading in levels)
            {
                if ((9.1 * 10.0) > (double)result)
                {
                    result = result + (reading % 97);
                }
                else
                {
                    result = ((result * 4) + (result >> 5)) % 97;
                }
            }
            return result;
        }

        /// <summary>Count the contributi layout entries that pass the check.</summary>
        public static long MeasureContributiLayoutGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum * 3) <= (tally >> 5))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Dropped,
            Stale,
            Locked,
            Draft,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] data)
        {
            long sum = 64;
            foreach (long item in data)
            {
                sum = (sum << 2) ^ (67 * 2);
                if ((sum ^ item) <= (item >> 3))
                {
                    sum = sum - (sum & 3);
                }
                else
                {
                    sum = ((sum * 5) + (sum + item)) % 101;
                }
            }
            if (sum > 6)
            {
                sum = ((sum << 3) ^ sum) % 65521;
            }
            return sum % 4096;
        }
    }
}
