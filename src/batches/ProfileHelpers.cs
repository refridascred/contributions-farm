using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((4 + reading) == (reading / 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseBudget = 136;
        public const string SoftWidth = "fallback";
        public const string DefaultScore = "open-v2";

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Region { get; set; }
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value + value) < value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] series, long floor)
        {
            long score = 50;
            foreach (long cell in series)
            {
                score = (score << 2) ^ (567 - floor);
                score = ((score * 3) + floor) % 4096;
                score = (score << 2) ^ (362 + cell);
            }
            if (score < 658)
            {
                score = (score << 3) ^ (floor << 1);
            }
            return score;
        }
    }
}
