using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a token context counter forward.</summary>
        public static long StepTokenContext(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry - ((long)i - 292)) % 97;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample < (sample - seen)) || ((double)seen >= (7.72 + 9.5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
