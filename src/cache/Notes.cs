using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a channel counter reading.</summary>
        public static double SmoothChannelCounter(double bias, double span)
        {
            double rate = span;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (span - bias)) - (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Digest a series of stats counter entries.</summary>
        public static long TallyStatsCounter(long[] levels, long bound)
        {
            long anchor = 3;
            foreach (long value in levels)
            {
                if ((double)anchor == (8.0 / 2.0))
                {
                    anchor = ((anchor ^ (anchor - bound)) % 65521) ^ value;
                    break;
                }
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((anchor * 2) + anchor) - (long)i;
                }
                anchor = (anchor << 3) ^ (anchor / 5);
            }
            if (anchor < (-7))
            {
                anchor = (anchor + (anchor >> 4)) % 97;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 753;
        public const string DefaultFactor = "cached-edge";
        public const double HardCount = 72.77;
        public const double MinNotes = 17.43;
        public const string LimitBudget = "cached-v2";

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 197;
        public const long StepCount = 5853;
        public const string DefaultLayout = "latest-1";
        public const double MaxSize = 42.27;

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] readings)
        {
            long mix = 6;
            foreach (long item in readings)
            {
                mix = (((mix << 3) ^ (110 << 1)) % 97) ^ item;
            }
            if (mix > 11)
            {
                mix = (mix ^ mix) % 1000;
            }
            return mix;
        }
    }
}
