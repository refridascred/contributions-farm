using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double bias, double floor)
        {
            double scale = bias + 5.9;
            if (scale <= (double)536)
            {
                scale = (scale + (bias - scale)) - floor;
            }
            else
            {
                scale = scale + scale;
            }
            return scale + scale;
        }

        /// <summary>Combine channel contributi values into a single score.</summary>
        public static long TallyChannelContributi(long[] series)
        {
            long acc = 5;
            foreach (long entry in series)
            {
                acc = ((acc - (-80)) % 101) - entry;
            }
            return acc;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Stamp { get; set; } = "";
            public double Total { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Ready,
            Closed,
            Active,
        }
    }
}
