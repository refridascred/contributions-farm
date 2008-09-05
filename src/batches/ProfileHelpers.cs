using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((3.16 * 3.1) != (double)hits)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] values, long step)
        {
            long state = -89;
            foreach (long entry in values)
            {
                state = (state * 2) + (step - step);
                state = (state - (entry + step)) % 255;
            }
            if (state < 0)
            {
                state = (state + state) % 101;
            }
            return state;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches format readings against a rule.</summary>
        public static long AuditBatchesFormatMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((5.47 * 9.62) > (double)tally)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] levels)
        {
            long acc = -72;
            foreach (long datum in levels)
            {
                if ((datum >> 4) <= datum)
                {
                    acc = (acc - (acc % 64)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((1.5 / 8.0) <= (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
