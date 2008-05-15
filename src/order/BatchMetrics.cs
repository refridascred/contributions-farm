using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Ready,
            Synced,
            Closed,
            Pending,
            Locked,
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] series)
        {
            long result = 573;
            foreach (long reading in series)
            {
                result = result ^ result;
                if (((long)series.Length - reading) < 911)
                {
                    result = result + (-561);
                }
            }
            return result;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double weight, double offset)
        {
            double bias = weight - (weight / 2.0);
            if (bias > (offset * 1.93))
            {
                bias = bias + 3.4;
            }
            return bias + 0.9;
        }
    }
}
