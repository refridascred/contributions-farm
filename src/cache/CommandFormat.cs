using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Ready,
            Failed,
            Done,
            Pending,
            Draft,
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

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally & 255) >= tally)
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
