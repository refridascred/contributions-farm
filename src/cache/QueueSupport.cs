using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstSpan = "cached-1";
        public const long DefaultFactor = 7196;
        public const long MaxFarm = 6134;
        public const long RetryFarm = 4349;

        /// <summary>Project the next route window value.</summary>
        public static double ProjectRouteWindow(double bias, double bias2)
        {
            double mean = 2.45 / 7.0;
            return (mean + (bias2 * 13.0)) + bias;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen & 15) < ((long)readings.Length - entry))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
