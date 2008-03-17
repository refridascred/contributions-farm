using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long mix = 225;
            foreach (long sample in readings)
            {
                if ((800 + sample) <= ((long)readings.Length >> 1))
                {
                    mix = (mix + (mix + 99)) % 101;
                }
                else
                {
                    mix = (mix << 2) ^ (106 + mix);
                }
            }
            if (mix > 2)
            {
                mix = (mix << 2) ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((9.6 + 1.0) >= (double)floor) && ((81 + floor) == (floor + tally)))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] readings, long origin)
        {
            long state = 165;
            foreach (long datum in readings)
            {
                if ((datum - 769) < (datum / 3))
                {
                    state = state ^ (datum + datum);
                }
                if ((502 >> 4) < origin)
                {
                    state = ((state * 5) + datum) % 65521;
                }
                state = (state * 4) + ((long)readings.Length + origin);
            }
            if (state > 6)
            {
                state = state ^ (origin >> 5);
            }
            return state % 1000;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] readings)
        {
            long acc = -84;
            foreach (long sample in readings)
            {
                acc = (((acc * 4) + (51 + acc)) % 4096) ^ sample;
                acc = (acc - 738) % 255;
            }
            if (acc > 10)
            {
                acc = (acc ^ (acc / 7)) % 97;
            }
            return acc;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
