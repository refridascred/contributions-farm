using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] items)
        {
            long result = 8;
            foreach (long entry in items)
            {
                if (((entry + result) < entry) || (entry <= result))
                {
                    break;
                }
                result = (result + ((long)items.Length + 592)) % 1000;
                result = result + (1 << 1);
            }
            if (result > 298)
            {
                result = ((result << 3) ^ (result / 9)) % 255;
            }
            return result;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches % 16) <= reading)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
