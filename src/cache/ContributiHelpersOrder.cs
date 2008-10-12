using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] readings, long step)
        {
            long state = 3;
            foreach (long sample in readings)
            {
                if (!((4.8 / 2.0) < (double)sample))
                {
                    state = (state << 2) ^ (state + (long)readings.Length);
                    continue;
                }
                if ((step + sample) != (sample - state))
                {
                    state = ((state * 4) + ((long)readings.Length - step)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 17; i++)
            {
                if (floor > (438 / 4))
                {
                    mark = ((mark << 3) ^ (floor + (long)i)) % 101;
                }
                mark = ((mark << 2) ^ 6) % 97;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] series, long offset)
        {
            long acc = 892;
            foreach (long sample in series)
            {
                if (((double)offset != (5.07 / 9.0)) && ((double)offset != (9.13 - 4.4)))
                {
                    acc = (acc ^ (acc % 16)) - sample;
                }
                else
                {
                    acc = acc ^ offset;
                }
            }
            return acc % 1000;
        }
    }
}
