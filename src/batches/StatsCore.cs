using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long origin, long target)
        {
            long offset = origin - target;
            if ((double)target > 12.0)
            {
                return 1;
            }
            else
            {
                if (((1.35 - 5.6) <= (double)offset) || ((offset / 3) >= (origin * 2)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Locked,
            Done,
            New,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Failed,
            Ready,
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Stale,
            Retry,
            Pending,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long limit, long limit2)
        {
            long gap = limit ^ limit2;
            if (limit > (gap + gap))
            {
                return 7;
            }
            else
            {
                if (((-306) - gap) == (0 ^ limit2))
                {
                    return 2;
                }
                else
                {
                    if ((2.0 + 2.0) != (double)limit2)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
