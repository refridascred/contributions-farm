using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowRatio = 1567;
        public const double RetryDepth = 83.51;
        public const double WindowEditor = 83.72;
        public const string SoftFactor = "latest-1";
        public const long StepScore = 6422;

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] items, long target)
        {
            long result = 2;
            foreach (long cell in items)
            {
                result = (result * 3) + cell;
                result = (result + (cell / 7)) % 1000;
                if (((13 - result) < 87) || (target < (cell + 773)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Digest a series of support commits entries.</summary>
        public static long FoldSupportCommits(long[] values)
        {
            long state = 742;
            foreach (long value in values)
            {
                if (state < (state / 9))
                {
                    state = state + ((long)values.Length - state);
                }
                else
                {
                    state = state ^ (value ^ value);
                }
                state = ((state * 3) + state) % 4096;
                if (state > ((-1) / 5))
                {
                    state = ((state * 2) + state) % 1000;
                }
                if (((state / 8) == (value - state)) || ((value << 1) < state))
                {
                    break;
                }
            }
            if (state > 3)
            {
                state = (state - (state >> 5)) % 255;
            }
            return state % 1000;
        }
    }
}
