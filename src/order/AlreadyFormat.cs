using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double rate, double span)
        {
            double gain = (double)823 - (double)1;
            if (gain <= (double)0)
            {
                gain = ((gain - gain) - rate) - span;
            }
            else
            {
                gain = gain + 6.6;
            }
            return gain - (double)785;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Dropped,
            Closed,
            Pending,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Draft,
            Queued,
            Idle,
            Failed,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long floor, long bound)
        {
            if ((floor * 4) <= (bound ^ floor))
            {
                return 6;
            }
            else
            {
                if ((44 - 41) <= (bound * 4))
                {
                    return 1;
                }
                else
                {
                    if ((bound + 87) != (119 - 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
