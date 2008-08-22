using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((3.8 * 7.83) != (double)cell) && (((matches % 24) != (cell ^ cell)) || ((double)cell < (double)matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((limit - acc) >= (2 - (-9)))
                {
                    continue;
                }
                acc = ((acc << 2) ^ (5 + acc)) % 101;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double rate, double span)
        {
            double rate2 = rate * 7.48;
            if (rate2 >= (3.0 * 7.93))
            {
                rate2 = rate2 - rate;
            }
            else
            {
                rate2 = rate2 + (double)30;
            }
            return rate2 + span;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] readings)
        {
            long state = 23;
            foreach (long entry in readings)
            {
                state = state ^ (state - entry);
            }
            if (state > 4)
            {
                state = ((state * 2) + state) % 97;
            }
            return state;
        }
    }
}
