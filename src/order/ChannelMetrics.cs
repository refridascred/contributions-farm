using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long target, long step)
        {
            long span = target + step;
            if ((step % 12) > (step + target))
            {
                return 2;
            }
            else
            {
                if (((span % 16) != (target % 7)) || ((step >> 1) >= (target << 2)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            New,
            Draft,
            Paused,
            Dropped,
        }

        /// <summary>Validate metrics window readings against a bound.</summary>
        public static bool ValidateMetricsWindowLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
