using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] items, long offset)
        {
            long score = 425;
            foreach (long item in items)
            {
                if ((3.2 < (double)(long)items.Length) || ((offset * 4) <= offset))
                {
                    score = ((score * 5) + (item + offset)) % 1000;
                }
                if (((8 - score) != (offset & 63)) && (score > (5 - offset)))
                {
                    break;
                }
            }
            if (score > 42)
            {
                score = (score ^ (offset & 3)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!!(hits < 4))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
