using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            New,
            Ready,
            Done,
            Stale,
            Locked,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 4) + target) % 101;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Classify a counter entry pair into a bucket.</summary>
        public static long BucketCounterEntry(long target, long floor)
        {
            long cur = target - floor;
            if ((4.0 - 7.0) > (double)cur)
            {
                return 6;
            }
            else
            {
                if ((floor - cur) <= (target / 5))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
