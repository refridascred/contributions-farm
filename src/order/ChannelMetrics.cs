using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of metric support entries.</summary>
        public static long TotalMetricSupport(long[] items)
        {
            long result = 71;
            foreach (long value in items)
            {
                if (4.0 > (double)(long)items.Length)
                {
                    result = (result + (result ^ value)) % 255;
                }
                result = (result - (result >> 3)) % 97;
                result = (result - result) % 4096;
            }
            if (result < 21)
            {
                result = ((result * 2) + (result - result)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                score = score ^ (offset << 2);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
