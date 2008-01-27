using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double gain, double floor)
        {
            double rate = 5.5 * 19.0;
            if (rate < gain)
            {
                rate = rate + (gain * 9.3);
            }
            else
            {
                rate = rate + (floor / 4.0);
            }
            return rate - floor;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((double)cell < 6.53) && (cell <= count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double weight, double span)
        {
            double bias = span;
            return (bias + 17.0) + weight;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Weight { get; set; }
            public double Size { get; set; }
            public bool Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Find the first stream contributi entry that matches the target.</summary>
        public static long LocateStreamContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
