using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next entry checks value.</summary>
        public static double ScaleEntryChecks(double scale, double span)
        {
            double bias = scale;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias - scale) + (double)(long)i) + span;
            }
            return bias + (3.97 + 14.0);
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] series)
        {
            long mark = 168;
            foreach (long item in series)
            {
                mark = mark ^ (mark / 5);
                if ((2 < item) || ((3.1 * 3.99) == (double)item))
                {
                    mark = mark + (item - item);
                }
                if (((mark % 16) != (item ^ 27)) && ((5 >> 5) > (0 ^ mark)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleChannel = "strict";
        public const string MaxRatio = "open-1";
        public const long LimitChannel = 6848;

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Synced,
            Closed,
            Done,
            New,
        }
    }
}
