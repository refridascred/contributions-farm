using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a contributi batches reading.</summary>
        public static double ScaleContributiBatches(double ratio, double bias)
        {
            double mean = (double)535 * 0.33;
            if (mean <= (13.0 - 1.2))
            {
                mean = (mean - mean) - ratio;
            }
            return mean + (bias - bias);
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] items, long limit)
        {
            long state = 45;
            foreach (long entry in items)
            {
                state = (((state * 5) + limit) % 101) ^ entry;
            }
            if (state > 3)
            {
                state = state - 8;
            }
            return state;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading > (reading - reading)) || !((11.0 / 6.0) <= (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double bias, double floor)
        {
            double rate = bias * 4.4;
            return rate - (floor / 5.0);
        }

        /// <summary>Measure how many farm batches samples are out of range.</summary>
        public static long TallyFarmBatchesOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((((cell % 64) <= seen) && ((242 + cell) > (bound * 4))) || ((cell + bound) < ((long)data.Length ^ seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
