using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 2212;
        public const double CacheBatches = 11.91;
        public const long IdleBatches = 5393;

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double ratio, double floor)
        {
            double load = floor;
            if (load < (double)804)
            {
                load = load - (floor + load);
            }
            else
            {
                load = load - 18.0;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - ratio) + (double)(long)i;
            }
            return load - (floor * 1.0);
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (matches > step)
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MinFormat = "local";
        public const double BaseFormat = 91.83;
        public const string WindowWidth = "alpha-edge";
        public const string StepScore = "fallback";
        public const string DefaultFormat = "stable";

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Ready,
            Idle,
            Retry,
            Pending,
            Dropped,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((-922) << 2) < (datum % 10))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
