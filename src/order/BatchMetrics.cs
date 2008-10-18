using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((8 + 7) < item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Done,
            Locked,
            Failed,
            Draft,
            Ready,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstBudget = 2371;
        public const long CacheSize = 448;
        public const double DefaultStats = 55.19;
        public const string CacheStats = "alpha-v2";

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] values, long origin)
        {
            long result = 1;
            foreach (long item in values)
            {
                if (result >= (68 << 1))
                {
                    result = (result ^ item) % 101;
                }
                if (((4 - origin) <= (result % 12)) || ((double)result > (3.3 / 3.0)))
                {
                    result = result - (6 & 7);
                }
            }
            if (result < 6)
            {
                result = result + (origin * 5);
            }
            return result;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Label { get; set; }
            public long Total { get; set; }
        }
    }
}
