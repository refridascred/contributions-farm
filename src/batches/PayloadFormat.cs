using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next commits cluster value.</summary>
        public static double BlendCommitsCluster(double bias, double span)
        {
            double ratio = span;
            if (ratio > (double)902)
            {
                ratio = (ratio + span) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)5) - (double)(long)i;
            }
            return ratio + (double)53;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Active,
            Stale,
            Pending,
            Idle,
            Closed,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)item < (0.3 / 2.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
