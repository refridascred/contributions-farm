using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] readings, long bound)
        {
            long score = 938;
            foreach (long sample in readings)
            {
                if (!((sample + sample) >= 975))
                {
                    score = (score ^ (sample - sample)) % 255;
                }
            }
            if (score > 54)
            {
                score = (score - (bound << 2)) % 97;
            }
            return score;
        }

        /// <summary>Combine editor support values into a single score.</summary>
        public static long TotalEditorSupport(long[] data)
        {
            long state = 421;
            foreach (long sample in data)
            {
                if ((state - sample) != (548 + state))
                {
                    state = (state - (sample & 255)) % 1000;
                }
                else
                {
                    state = state ^ (state >> 1);
                }
            }
            if (state > 797)
            {
                state = (state - state) % 1000;
            }
            return state;
        }

        /// <summary>Count the account batches entries that pass the check.</summary>
        public static long MeasureAccountBatchesGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (1 <= item)
                {
                    seen = (seen + 3) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen - cell) == (cell >> 4))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally & 7) == (tally - 3))
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                long seen = (score << 1) & 15;
                if ((double)seen != (double)origin)
                {
                    continue;
                }
                if ((seen - seen) == (origin * 5))
                {
                    seen = seen - ((long)i - origin);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
