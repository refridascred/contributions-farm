using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Score { get; set; }
            public double Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Validate filter stats readings against a bound.</summary>
        public static bool GuardFilterStatsLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double mean = (double)(49 + 839);
            if (mean <= gain)
            {
                mean = mean + 7.0;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean - (floor + 4.0);
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
