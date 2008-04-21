using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = (((state << 3) ^ bound) % 65521) + (long)i2;
                    state = (state + bound) % 65521;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many batch filter samples are out of range.</summary>
        public static long MeasureBatchFilterMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((matches & 7) <= (entry + matches)) || ((matches & 127) >= (entry << 2)))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] series)
        {
            long sum = 5;
            foreach (long value in series)
            {
                if ((4.7 + 5.0) != (double)value)
                {
                    sum = (sum << 3) ^ (value >> 1);
                }
                else
                {
                    sum = (sum - (sum % 60)) % 101;
                }
            }
            return sum % 4096;
        }
    }
}
