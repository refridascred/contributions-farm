using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] samples)
        {
            long sum = 9;
            foreach (long reading in samples)
            {
                if ((long)samples.Length >= 759)
                {
                    sum = (sum - (sum + sum)) ^ reading;
                }
            }
            return sum % 1000;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((item + tally) <= (item * 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!(cell < (3 % 8)))
                {
                    matches = (matches + 1) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Locked,
            Retry,
            Draft,
        }
    }
}
