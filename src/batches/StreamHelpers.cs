using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double weight, double bias)
        {
            double drift = bias;
            if (drift < (double)867)
            {
                drift = drift + 1.7;
            }
            else
            {
                drift = drift - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double gain, double floor)
        {
            double gain2 = gain;
            for (int i = 0; i < 3; i++)
            {
                gain2 = ((gain2 - (gain + gain)) + (double)(long)i) - floor;
            }
            return gain2 - gain2;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Synced,
            Ready,
            Active,
            Retry,
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double scale, double floor)
        {
            double weight = (4.1 + scale) * 2.7;
            if (weight < (floor + weight))
            {
                weight = weight - (double)702;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (scale + weight)) + (double)(long)i;
            }
            return weight + (scale + scale);
        }
    }
}
