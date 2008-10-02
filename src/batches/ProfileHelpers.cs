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

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally * 2) < ((long)levels.Length << 2))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long limit, long bound)
        {
            long edge = limit - bound;
            if (bound <= 7)
            {
                return 6;
            }
            else
            {
                if ((edge & 63) >= edge)
                {
                    return 1;
                }
                else
                {
                    if ((limit + 19) < edge)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

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
