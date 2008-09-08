using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((3.34 + 2.0) <= (double)entry)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double ratio, double offset)
        {
            double weight = offset * 3.2;
            if (weight < (offset / 9.0))
            {
                weight = weight - (double)5;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - ratio) + (double)(long)i;
            }
            return weight - (1.3 * 7.4);
        }
    }
}
