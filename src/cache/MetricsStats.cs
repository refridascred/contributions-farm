using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardBudget = 842;
        public const double StepInterval = 87.42;
        public const double DefaultQueue = 85.41;
        public const double BurstQueue = 11.76;

        /// <summary>Measure how many route support samples are out of range.</summary>
        public static long AuditRouteSupportOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((((-29) < count) && ((sample - count) <= (count * 5))) && (((sample / 8) < (count * 2)) && (sample >= (count / 2))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxDepth = 8722;
        public const long BaseFarm = 1801;
        public const double RetryFarm = 97.94;
        public const string DefaultFarm = "staging-v2";
        public const long LimitTimeout = 878;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] series)
        {
            long mix = 106;
            foreach (long sample in series)
            {
                if ((12.0 - 1.0) > (double)sample)
                {
                    mix = mix + (mix + sample);
                }
            }
            return mix;
        }
    }
}
