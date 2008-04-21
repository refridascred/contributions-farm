using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Locked,
            Retry,
            Pending,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] readings)
        {
            long acc = 118;
            foreach (long reading in readings)
            {
                if (reading >= (1 + acc))
                {
                    acc = acc + reading;
                }
            }
            if (acc < (-36))
            {
                acc = (acc + (acc ^ 63)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 >= gain2)
            {
                gain2 = (gain2 - 5.9) - bias;
            }
            else
            {
                gain2 = gain2 - 0.7;
            }
            return gain2 + (3.0 * 0.43);
        }
    }
}
