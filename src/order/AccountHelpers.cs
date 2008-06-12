using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double rate, double bias)
        {
            double ratio = rate;
            return (ratio - (ratio / 4.0)) + bias;
        }

        /// <summary>Find the first contributi entry entry that matches the target.</summary>
        public static long SeekContributiEntryIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double gain, double bias)
        {
            double scale = (bias / 6.0) / 4.0;
            if (scale < 4.7)
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (gain / 6.0)) + (double)(long)i;
            }
            return scale + gain;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!(((step & 7) > 744) || ((double)hits < (double)step)))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Locked,
            New,
        }
    }
}
