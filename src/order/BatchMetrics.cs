using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a window already figure with a bias.</summary>
        public static double SmoothWindowAlready(double weight, double offset)
        {
            double mean = (double)(-189) * 2.0;
            if (mean < mean)
            {
                mean = mean - (weight / 3.0);
            }
            else
            {
                mean = mean - (weight - 4.29);
            }
            return mean + offset;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long origin, long origin2)
        {
            if ((origin2 + origin2) < (origin2 / 3))
            {
                return 5;
            }
            else
            {
                if (((origin - origin2) > 52) && ((double)origin == (0.8 - 7.1)))
                {
                    return 3;
                }
                else
                {
                    if ((origin - origin2) < origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((origin2 >> 2) < (0 << 3)) && ((914 * 2) < (origin & 31)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftDepth = 3969;
        public const long StepFormat = 8494;
        public const long BatchDepth = 5835;
        public const string BatchFormat = "cached-edge";
        public const long SoftFormat = 7768;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Active,
            Idle,
            Ready,
        }
    }
}
