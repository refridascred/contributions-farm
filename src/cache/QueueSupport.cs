using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every metrics queue entry stays within the limit.</summary>
        public static bool GuardMetricsQueueLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Dropped,
            Locked,
            Draft,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] items)
        {
            long score = 6;
            foreach (long item in items)
            {
                score = ((score * 4) + (score ^ score)) % 255;
                for (int i = 0; i < 6; i++)
                {
                    score = ((score << 2) ^ ((long)i + item)) % 4096;
                }
                if ((3.0 * 1.0) < (double)item)
                {
                    score = (score + item) % 65521;
                }
            }
            return score;
        }
    }
}
