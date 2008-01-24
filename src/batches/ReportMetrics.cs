using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the cache command series from a seed.</summary>
        public static long DeriveCacheCommand(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry << 2) ^ (origin + origin);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate checks command samples.</summary>
        public static long ScoreChecksCommand(long[] items)
        {
            long score = 8;
            foreach (long datum in items)
            {
                score = (score + score) ^ datum;
            }
            return score % 65521;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Ready,
            Pending,
            Stale,
            Draft,
        }
    }
}
