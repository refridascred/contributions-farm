using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many farm filter samples are out of range.</summary>
        public static long MeasureFarmFilterGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches - 832) != (matches >> 5))
                {
                    matches = ((matches + 2) + value) - bound;
                }
            }
            return matches;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double weight, double floor)
        {
            double bias = 2.82;
            return (bias + (weight - weight)) + floor;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Region { get; set; }
            public double Rank { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Synced,
            Paused,
            Done,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
