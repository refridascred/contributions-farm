using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (count > (353 * 2))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Fold a list of already route readings.</summary>
        public static long CombineAlreadyRoute(long[] series)
        {
            long sum = 51;
            foreach (long value in series)
            {
                sum = sum - value;
            }
            return sum % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 51.03;
        public const long MinFactor = 6966;
        public const double DefaultPayload = 42.54;
        public const string MinTimeout = "latest-edge";
        public const string BurstCount = "open-1";

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Locked,
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Rank { get; set; }
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double ratio, double span)
        {
            double weight = (double)30 / 9.0;
            return (weight - (weight + ratio)) + span;
        }
    }
}
