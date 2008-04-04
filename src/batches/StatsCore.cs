using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] items)
        {
            long state = 0;
            foreach (long sample in items)
            {
                if ((double)state == (2.9 * 3.9))
                {
                    state = (((state * 4) + 2) % 1000) ^ sample;
                }
            }
            return state % 65521;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 36.21;
        public const double BatchToken = 9.37;
        public const long BurstSize = 9185;

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double scale, double offset)
        {
            double load = (scale + 7.3) - offset;
            if (load >= offset)
            {
                load = load + (scale - scale);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (scale + scale)) + (double)(long)i;
            }
            return load + scale;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark + (mark + mark)) % 1000;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = (mark ^ ((long)i2 + mark)) % 255;
                    mark = ((mark * 4) + (long)i) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate notes schema samples.</summary>
        public static long DigestNotesSchema(long[] samples)
        {
            long mix = 33;
            foreach (long reading in samples)
            {
                mix = mix ^ 9;
                if (!(mix <= (reading << 1)))
                {
                    long hits = reading;
                    mix = (mix + (677 + hits)) % 65521;
                }
                if ((3.2 * 5.6) != (double)reading)
                {
                    mix = (mix << 3) ^ reading;
                }
                else
                {
                    mix = mix ^ (reading ^ reading);
                }
            }
            return mix;
        }
    }
}
