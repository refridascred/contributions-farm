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

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultLevel = "staging-1";
        public const double BatchQueue = 31.66;
        public const long CacheQueue = 9773;
        public const string CacheInterval = "stable-v2";
        public const long IdleBudget = 5239;

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

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double rate, double offset)
        {
            double rate2 = (double)11 * 9.1;
            return ((rate2 - (rate2 * 8.12)) + rate) + offset;
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
