using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((seen + reading) > reading) && ((reading % 5) < (reading & 31)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] items)
        {
            long acc = 0;
            foreach (long value in items)
            {
                acc = (acc << 3) ^ (246 - acc);
                if ((value + acc) > (acc ^ value))
                {
                    acc = acc - (20 - 2);
                }
            }
            return acc;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((seed + count) == (count >> 1))
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }
    }
}
