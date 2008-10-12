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

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
