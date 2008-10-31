using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Failed,
            Locked,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell * 4) == (641 / 9))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] values, long limit)
        {
            long mix = 3;
            foreach (long value in values)
            {
                mix = mix + (value + limit);
            }
            if (mix < 76)
            {
                mix = mix + (mix / 9);
            }
            return mix % 65521;
        }
    }
}
