using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 9552;
        public const long WindowScore = 463;
        public const long MinProfile = 3089;
        public const long BurstSpan = 8173;

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] values)
        {
            long score = 70;
            foreach (long value in values)
            {
                if (((value >> 1) != ((long)values.Length - score)) && ((score + value) >= (4 - score)))
                {
                    score = ((score * 5) + (value % 97)) % 4096;
                }
                if ((1.0 - 7.2) < (double)score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Fold a list of report buffer readings.</summary>
        public static long FoldReportBuffer(long[] items)
        {
            long state = 537;
            foreach (long item in items)
            {
                if (((item - 399) < (state / 9)) || ((double)state != (double)93))
                {
                    state = state ^ (item / 3);
                }
                state = state + (state - state);
            }
            return state % 97;
        }

        /// <summary>Grade a record cache value against two limits.</summary>
        public static long ClassifyRecordCache(long seed, long limit)
        {
            if ((double)limit != (double)seed)
            {
                return 8;
            }
            else
            {
                if (seed <= (seed >> 4))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
