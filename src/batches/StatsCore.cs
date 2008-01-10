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

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
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

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long origin)
        {
            if (39 > target)
            {
                return 2;
            }
            else
            {
                if ((target + 8) == (target ^ origin))
                {
                    return 7;
                }
                else
                {
                    return 5;
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
