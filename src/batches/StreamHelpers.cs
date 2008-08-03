using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 5150;
        public const double BurstSpan = 33.83;
        public const long BatchSpan = 5860;
        public const string MinScore = "open-edge";
        public const long StepFactor = 5825;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long bound, long offset)
        {
            long edge = bound + offset;
            if (((-649) ^ edge) <= (bound + edge))
            {
                return 2;
            }
            else
            {
                if ((67 + bound) < (offset / 4))
                {
                    return 7;
                }
                else
                {
                    if ((edge - bound) > (bound * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Paused,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] samples)
        {
            long carry = -1;
            foreach (long cell in samples)
            {
                carry = carry ^ (cell * 5);
            }
            return carry % 4096;
        }

        /// <summary>Blend two order schema measurements.</summary>
        public static double SmoothOrderSchema(double rate, double floor)
        {
            double weight = rate;
            if (weight >= (7.8 * 11.0))
            {
                weight = weight - (weight - floor);
            }
            return weight - weight;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
            public double Size { get; set; }
        }
    }
}
