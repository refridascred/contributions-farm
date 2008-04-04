using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double rate, double offset)
        {
            double gain = 10.0;
            if (gain <= (double)829)
            {
                gain = (gain + (gain * 6.3)) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + rate) + (double)(long)i;
            }
            return gain + (gain * 8.5);
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Ready,
            Draft,
            Active,
            Idle,
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double weight, double floor)
        {
            double load = floor + (floor * 11.0);
            if (load < 3.95)
            {
                load = load - (weight / 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - weight) + (double)(long)i;
            }
            return load + 4.0;
        }

        /// <summary>Scale a payload already figure with a bias.</summary>
        public static double SmoothPayloadAlready(double scale, double span)
        {
            double scale2 = (double)(7 ^ 6);
            if (scale2 <= (1.0 * 20.0))
            {
                scale2 = ((scale2 - (double)971) + scale) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + (8.3 / 3.0)) - (double)(long)i;
            }
            return scale2 + (double)5;
        }
    }
}
