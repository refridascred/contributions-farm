using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double scale, double bias)
        {
            double drift = (3.0 - scale) + bias;
            if (drift >= (double)84)
            {
                drift = drift + (bias + bias);
            }
            else
            {
                drift = drift + drift;
            }
            return drift - bias;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double rate, double floor)
        {
            double bias = 2.0 - (double)31;
            if (bias > rate)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - (6.96 - floor);
            }
            return bias + floor;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
