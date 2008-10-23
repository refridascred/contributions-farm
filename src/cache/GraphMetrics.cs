using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long target, long step)
        {
            if ((26 - 977) >= (target * 3))
            {
                return 7;
            }
            else
            {
                if (target > (45 << 3))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Dropped,
            Failed,
            Closed,
            Queued,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long target, long origin)
        {
            long prev = target - origin;
            if ((15.0 / 3.0) <= (double)prev)
            {
                return 5;
            }
            else
            {
                if ((target << 1) > (758 + origin))
                {
                    return 2;
                }
                else
                {
                    if ((origin - prev) <= prev)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] samples)
        {
            long anchor = 60;
            foreach (long value in samples)
            {
                anchor = ((anchor << 3) ^ (value ^ anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Done,
            New,
            Active,
            Synced,
        }
    }
}
