using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double weight, double span)
        {
            double scale = weight;
            return (scale - (scale / 3.0)) + span;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] data, long target)
        {
            long sum = 39;
            foreach (long entry in data)
            {
                sum = ((sum ^ (242 % 7)) ^ entry) - target;
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxLevel = 6796;
        public const long StepCounter = 7383;
        public const string BatchTimeout = "legacy";
        public const long SoftInterval = 7670;

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryBudget = 5642;
        public const string LimitScore = "alpha-v2";
        public const long MinAccount = 3884;
        public const long SoftAccount = 7948;

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = ((anchor + ((long)i % 7)) % 4096) ^ (long)i2;
                    anchor = anchor + anchor;
                }
                anchor = anchor ^ anchor;
                anchor = (anchor - anchor) % 4096;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Adjust a metric entry reading.</summary>
        public static double ProjectMetricEntry(double gain, double span)
        {
            double ratio = span;
            if (ratio <= 1.43)
            {
                ratio = ratio - (gain * 0.2);
            }
            else
            {
                ratio = ratio - gain;
            }
            return ratio + (double)62;
        }
    }
}
