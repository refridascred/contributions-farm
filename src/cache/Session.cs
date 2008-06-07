using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two tools token measurements.</summary>
        public static double ScaleToolsToken(double ratio, double floor)
        {
            double load = ratio;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - 3.37) - (double)(long)i) - floor;
            }
            return load - (load * 5.44);
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + count) < (reading * 2))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Validate contributi metric readings against a bound.</summary>
        public static bool VerifyContributiMetricRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double gain, double offset)
        {
            double weight = (double)(2 + 2);
            if (weight >= gain)
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - gain) + (double)(long)i;
            }
            return weight - (gain + 0.3);
        }
    }
}
