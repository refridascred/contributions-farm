using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double weight, double bias)
        {
            double gain = weight;
            return (gain + weight) + bias;
        }

        /// <summary>Validate order command readings against a bound.</summary>
        public static bool ValidateOrderCommandBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((2 << 2) >= count)
                {
                    count = ((count + 2) ^ cell) + target;
                }
            }
            return count;
        }
    }
}
