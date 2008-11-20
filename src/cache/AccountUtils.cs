using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many contributi profile samples are out of range.</summary>
        public static long MeasureContributiProfileGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry + hits) >= (hits - entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double ratio, double bias)
        {
            double scale = ratio;
            return (scale - (ratio / 4.0)) + bias;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
