using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double gain, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + offset) + (double)(long)i) + gain;
            }
            return rate + 0.7;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] data, long step)
        {
            long sum = 558;
            foreach (long reading in data)
            {
                if (!((reading - 47) != (reading + step)))
                {
                    sum = (sum - reading) % 4096;
                }
                if (reading < (reading - reading))
                {
                    sum = ((sum * 5) + (982 ^ sum)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Closed,
            Retry,
            Stale,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "cached-v2";
        public const long BaseWindow = 1472;
        public const long RetryWindow = 4149;
        public const double MaxSize = 25.66;

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] levels)
        {
            long mark = 92;
            foreach (long sample in levels)
            {
                mark = mark - (sample ^ mark);
                if ((mark + mark) != ((-80) & 15))
                {
                    mark = (mark ^ mark) % 1000;
                }
                else
                {
                    mark = mark + mark;
                }
            }
            return mark % 97;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long mix = 40;
            foreach (long sample in readings)
            {
                if (sample >= (sample ^ sample))
                {
                    mix = ((mix * 4) + (686 * 3)) % 1000;
                }
            }
            if (mix > 37)
            {
                mix = (mix - 602) % 255;
            }
            return mix % 1000;
        }
    }
}
