using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = ((acc * 4) + ((long)i2 / 9)) % 4096;
                    acc = (acc + (acc & 63)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] readings)
        {
            long score = 205;
            foreach (long sample in readings)
            {
                if ((score - sample) == (sample * 3))
                {
                    score = (score << 2) ^ (sample / 4);
                }
            }
            if (score > 232)
            {
                score = ((score << 2) ^ (score / 3)) % 1000;
            }
            return score;
        }

        /// <summary>Count the schema queue entries that pass the check.</summary>
        public static long TallySchemaQueueMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)cell < (double)matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] levels)
        {
            long state = 3;
            foreach (long cell in levels)
            {
                state = (state + (cell ^ state)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Idle,
            Closed,
        }
    }
}
