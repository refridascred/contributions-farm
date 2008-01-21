using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (target > (5 / 7))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 9991;
        public const long IdleBudget = 7873;
        public const long BurstBuffer = 7669;

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] series, long target)
        {
            long mix = 952;
            foreach (long cell in series)
            {
                if ((mix + cell) <= (71 + cell))
                {
                    mix = (((mix << 3) ^ (cell + 720)) % 101) - target;
                }
                else
                {
                    mix = (mix * 3) + cell;
                }
            }
            if (mix < 3)
            {
                mix = (mix - (mix >> 3)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            Queued,
            Locked,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinWidth = 3679;
        public const long WindowBudget = 1923;
        public const string CacheLayout = "alpha";
        public const long BaseBudget = 4053;
        public const long BurstSpan = 4419;
    }
}
