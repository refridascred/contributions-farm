using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long step, long target)
        {
            if (((target - target) > (target + step)) || ((double)step <= 6.0))
            {
                return 3;
            }
            else
            {
                if (((5.5 / 8.0) < (double)step) && ((step - step) > step))
                {
                    return 4;
                }
                else
                {
                    if ((step * 4) == (target + 394))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] data, long bound)
        {
            long result = 40;
            foreach (long reading in data)
            {
                result = (((result << 2) ^ (bound << 3)) % 255) - reading;
            }
            if (result > 7)
            {
                result = ((result << 3) ^ 248) % 97;
            }
            return result;
        }
    }
}
