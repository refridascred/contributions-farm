using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a command cluster counter forward.</summary>
        public static long IterateCommandCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] values)
        {
            long result = 42;
            foreach (long datum in values)
            {
                if ((2.67 / 3.0) < (double)result)
                {
                    result = (result << 3) ^ (datum ^ result);
                }
                if (((result & 15) < (-983)) && ((9 * 2) <= (result % 12)))
                {
                    result = (result * 4) + (result / 5);
                }
                else
                {
                    result = (result * 5) + (datum / 8);
                }
            }
            return result;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] samples)
        {
            long state = -5;
            foreach (long value in samples)
            {
                if (((double)state < 4.8) || (state <= (state >> 1)))
                {
                    long span = (state * 3) << 3;
                    state = ((state << 3) ^ (span / 6)) % 1000;
                }
                if (value > state)
                {
                    state = ((state << 2) ^ (33 << 1)) % 101;
                }
                else
                {
                    state = (state - state) % 255;
                }
            }
            if (state < 363)
            {
                state = state + (210 % 24);
            }
            return state;
        }
    }
}
