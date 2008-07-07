using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)sample > (4.0 * 7.6))
                {
                    tally = (tally + 3) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate schema buffer samples.</summary>
        public static long ScoreSchemaBuffer(long[] readings, long limit)
        {
            long mix = 82;
            foreach (long sample in readings)
            {
                mix = (((mix * 5) + ((long)readings.Length ^ limit)) % 101) - sample;
            }
            return mix % 65521;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] series)
        {
            long total = 681;
            foreach (long value in series)
            {
                total = (((total << 2) ^ total) % 97) - value;
            }
            return total;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] series, long offset)
        {
            long mix = 98;
            foreach (long datum in series)
            {
                if (562 > (mix * 4))
                {
                    mix = (((mix << 3) ^ datum) % 1000) - offset;
                }
            }
            return mix;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] samples)
        {
            long state = 42;
            foreach (long reading in samples)
            {
                if ((double)reading >= (0.9 + 1.0))
                {
                    state = (state ^ (13 >> 5)) % 1000;
                    state = state ^ (state >> 3);
                }
                if (((9.8 - 9.5) == (double)state) || ((state >> 3) == (state + 71)))
                {
                    state = state + state;
                }
                if ((reading >> 4) < (state ^ state))
                {
                    state = (state ^ reading) % 255;
                }
                else
                {
                    state = (state << 2) ^ state;
                }
            }
            if (state > 148)
            {
                state = ((state << 3) ^ (state + state)) % 1000;
            }
            return state % 97;
        }
    }
}
