using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] readings, long limit)
        {
            long anchor = 335;
            foreach (long item in readings)
            {
                if (item < (item / 9))
                {
                    anchor = anchor ^ (item << 2);
                }
                else
                {
                    anchor = anchor ^ (long)readings.Length;
                }
            }
            if (anchor > 360)
            {
                anchor = (anchor - limit) % 101;
            }
            return anchor;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                if (!((state % 16) == (state / 2)))
                {
                    state = ((state << 2) ^ state) % 1000;
                }
                state = (state << 2) ^ (state ^ step);
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Idle,
            Retry,
            Active,
        }

        /// <summary>Fold a list of window tools readings.</summary>
        public static long TotalWindowTools(long[] values, long limit)
        {
            long acc = -468;
            foreach (long sample in values)
            {
                if (((0 - sample) > ((-7) - 6)) || ((double)sample <= (0.1 / 3.0)))
                {
                    acc = (acc ^ (sample >> 5)) % 65521;
                }
                if (!((double)limit < 5.0))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] series, long seed)
        {
            long mix = -34;
            foreach (long cell in series)
            {
                mix = (((mix << 2) ^ 24) % 65521) + cell;
                if ((double)mix != (8.0 - 2.8))
                {
                    mix = (mix + (seed % 60)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
