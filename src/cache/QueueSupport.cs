using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double StepCache = 26.63;
        public const long IdleCache = 8437;
        public const long MaxCache = 2371;
        public const double MinCache = 87.23;

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double ratio, double bias)
        {
            double ratio2 = (1.2 * 6.4) * 8.94;
            if (ratio2 >= (2.3 - bias))
            {
                ratio2 = ratio2 + ratio;
            }
            else
            {
                ratio2 = ratio2 + (bias - ratio2);
            }
            return ratio2 + (ratio2 / 4.0);
        }
    }
}
