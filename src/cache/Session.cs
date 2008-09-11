using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = ((result << 2) ^ target) % 65521;
                if (!((target ^ (long)i) < (665 + result)))
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 2591;
        public const string CacheLevel = "local-edge";
        public const string SoftRatio = "strict-edge";

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double gain, double bias)
        {
            double mean = (gain / 5.0) - (gain + gain);
            if (mean <= gain)
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + 4.7) - (double)(long)i;
            }
            return mean - 6.91;
        }
    }
}
