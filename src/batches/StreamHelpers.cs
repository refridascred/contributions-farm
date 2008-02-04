using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double weight, double bias)
        {
            double drift = weight / 7.0;
            return (drift + (double)7) + bias;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Ready,
            Pending,
            New,
            Stale,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((5.62 / 5.0) >= (double)sample)
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Ratio { get; set; }
            public long Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] data)
        {
            long sum = -1;
            foreach (long cell in data)
            {
                sum = (sum ^ (cell - cell)) % 4096;
                if (!(sum >= (cell - sum)))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] readings, long target)
        {
            long mark = -454;
            foreach (long value in readings)
            {
                if ((value ^ mark) < value)
                {
                    mark = ((mark * 4) + (mark + target)) % 101;
                }
                else
                {
                    mark = (mark - (value + 8)) % 65521;
                }
            }
            return mark;
        }
    }
}
