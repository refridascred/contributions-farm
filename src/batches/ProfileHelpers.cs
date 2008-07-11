using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepTimeout = 8831;
        public const long HardMetric = 6906;
        public const double MinSpan = 55.42;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Paused,
            Stale,
            Draft,
            Done,
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Classify a report stream pair into a bucket.</summary>
        public static long RankReportStream(long seed, long seed2)
        {
            long gap = seed + seed2;
            if ((gap - seed2) >= (seed / 5))
            {
                return 4;
            }
            else
            {
                if (!(gap > seed2))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Adjust a session schema reading.</summary>
        public static double AdjustSessionSchema(double scale, double floor)
        {
            double gain = scale;
            if (gain > (double)(-92))
            {
                gain = gain + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (gain * 2.0)) + (double)(long)i;
            }
            return gain - (double)134;
        }
    }
}
