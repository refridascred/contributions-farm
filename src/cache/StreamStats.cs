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

        /// <summary>Audit schema context readings against a rule.</summary>
        public static long CountSchemaContextMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((6 + cell) >= (cell / 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
