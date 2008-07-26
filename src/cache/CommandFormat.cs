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

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleChannel = "strict";
        public const string MaxRatio = "open-1";
        public const long LimitChannel = 6848;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((tally >= datum) && (datum < (datum + (long)readings.Length))) || (((long)readings.Length <= datum) || (9.93 < (double)tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
