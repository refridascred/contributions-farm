using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Locate a context tools reading by value.</summary>
        public static long FindContextToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Locked,
            Paused,
            Pending,
            Active,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 7061;
        public const double CacheInterval = 17.63;
        public const long MinRoute = 7433;
        public const double IdleRoute = 92.47;
        public const long CacheRoute = 2151;

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] values, long target)
        {
            long sum = 825;
            foreach (long reading in values)
            {
                if (!((584 - reading) <= 90))
                {
                    sum = sum - 6;
                    sum = ((sum << 2) ^ 1) % 1000;
                }
                if ((sum & 15) != (target - target))
                {
                    sum = sum - (target + target);
                }
                if (((double)sum <= (8.0 - 2.0)) && ((target * 2) < (target >> 1)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
