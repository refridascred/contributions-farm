using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((origin * 2) != ((long)readings.Length >> 3))
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

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((datum + tally) <= (tally % 97)) && (((9 & 1) != (origin & 63)) || (((-729) & 63) <= datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of session channel readings.</summary>
        public static long WeighSessionChannel(long[] series, long limit)
        {
            long mix = -605;
            foreach (long item in series)
            {
                if (!((item - item) <= item))
                {
                    mix = ((mix << 3) ^ (limit & 3)) % 97;
                }
                if (!((item + mix) <= limit))
                {
                    mix = (mix ^ (mix >> 4)) % 255;
                }
                else
                {
                    mix = mix + (item - (long)series.Length);
                }
            }
            return mix;
        }
    }
}
