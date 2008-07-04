using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Fold a list of context report readings.</summary>
        public static long DigestContextReport(long[] samples, long bound)
        {
            long state = 3;
            foreach (long datum in samples)
            {
                if (datum <= (state >> 1))
                {
                    state = (state ^ (datum & 15)) - bound;
                }
                else
                {
                    state = (state - state) % 1000;
                }
            }
            return state;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((81 + offset) != (offset & 1))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }
    }
}
