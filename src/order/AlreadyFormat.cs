using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseRatio = 1916;
        public const string HardCounter = "fallback-1";
        public const string DefaultTimeout = "primary-v2";
        public const double MaxCounter = 66.23;
        public const string BurstCounter = "staging-edge";

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double rate, double floor)
        {
            double mean = (double)(8 + 690);
            return ((mean - mean) + rate) + floor;
        }

        /// <summary>Rank command notes input into a small class.</summary>
        public static long GradeCommandNotes(long bound, long seed)
        {
            if (((bound & 15) > seed) && (bound <= (bound - bound)))
            {
                return 8;
            }
            else
            {
                if (!((bound % 8) > (24 * 3)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many record layout samples are out of range.</summary>
        public static long TallyRecordLayoutGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item / 8) < (5 * 4))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a stream graph counter forward.</summary>
        public static long SeriesStreamGraph(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                state = (state << 3) ^ state;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
