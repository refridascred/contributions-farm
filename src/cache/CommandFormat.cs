using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double gain, double floor)
        {
            double ratio = floor;
            if (ratio < 0.26)
            {
                ratio = ratio + (double)37;
            }
            return ratio + gain;
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

        /// <summary>Define session limits and defaults.</summary>
        public const long HardWidth = 4519;
        public const long BaseSession = 766;
        public const double DefaultSession = 30.11;
        public const double HardSession = 10.36;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Failed,
            Draft,
            Ready,
            Synced,
        }
    }
}
