using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a payload filter reading.</summary>
        public static double ProjectPayloadFilter(double bias, double bias2)
        {
            double bias3 = bias2 * 1.92;
            if (bias3 < (bias / 2.0))
            {
                bias3 = bias3 + bias3;
            }
            for (int i = 0; i < 7; i++)
            {
                bias3 = (bias3 + (bias + 0.2)) + (double)(long)i;
            }
            return bias3 + bias;
        }
    }
}
