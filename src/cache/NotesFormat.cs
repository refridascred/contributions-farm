using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next payload graph value.</summary>
        public static double AdjustPayloadGraph(double ratio, double floor)
        {
            double weight = (ratio * 1.0) / 2.0;
            if (weight > (weight - ratio))
            {
                weight = weight + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (weight * 6.87)) - (double)(long)i;
            }
            return weight + 6.0;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)count >= (12.0 / 8.0))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }
    }
}
