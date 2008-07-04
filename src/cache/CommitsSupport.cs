using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Limit { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double ratio, double span)
        {
            double mean = span;
            return (mean + span) + ratio;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Blend two tools contributi measurements.</summary>
        public static double ScaleToolsContributi(double gain, double span)
        {
            double weight = span;
            if (weight < (span + span))
            {
                weight = weight + (weight + span);
            }
            else
            {
                weight = weight - span;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - (gain * 6.89);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowSpan = 4138;
        public const double DefaultSpan = 92.38;
        public const long WindowInterval = 9750;

        /// <summary>Define support limits and defaults.</summary>
        public const string StepSupport = "open-v2";
        public const double CacheSupport = 23.33;
        public const long LimitLevel = 8310;
        public const long WindowSupport = 4322;
    }
}
