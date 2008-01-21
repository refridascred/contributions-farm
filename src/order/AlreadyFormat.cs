using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Closed,
            Active,
            Locked,
        }

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
