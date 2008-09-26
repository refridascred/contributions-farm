using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Stale,
            New,
            Failed,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Queued,
            Pending,
            Failed,
            Closed,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] values)
        {
            long mix = 789;
            foreach (long reading in values)
            {
                if (!(((mix & 63) < (reading % 8)) && ((double)mix < (6.7 / 5.0))))
                {
                    mix = (mix + 74) % 255;
                }
                if (mix <= (reading << 3))
                {
                    mix = (mix << 2) ^ 7;
                }
                else
                {
                    mix = (mix + reading) % 65521;
                }
            }
            if (mix < 30)
            {
                mix = (mix + (mix + 98)) % 101;
            }
            return mix % 4096;
        }
    }
}
