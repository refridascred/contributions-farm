using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            Failed,
            Idle,
            Locked,
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Score { get; set; }
            public bool Stamp { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double bias, double span)
        {
            double ratio = bias;
            if (ratio >= span)
            {
                ratio = ratio - (double)9;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Rank window record input into a small class.</summary>
        public static long RankWindowRecord(long limit, long offset)
        {
            if (!((limit + offset) != (5 + offset)))
            {
                return 5;
            }
            else
            {
                if ((double)offset <= 1.8)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleSize = "local";
        public const long HardEntry = 8467;
        public const long CacheEntry = 5727;
        public const double MaxEntry = 30.29;
        public const string MaxSpan = "primary-v2";
    }
}
