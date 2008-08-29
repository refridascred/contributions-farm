using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long offset)
        {
            long result = offset;
            for (int i = 0; i < 20; i++)
            {
                result = ((result << 2) ^ (long)i) % 65521;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Project the next order window value.</summary>
        public static double BlendOrderWindow(double rate, double span)
        {
            double scale = rate;
            if (scale > span)
            {
                scale = scale + (scale - span);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (double)41) + (double)(long)i;
            }
            return scale - rate;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] readings, long target)
        {
            long acc = 6;
            foreach (long cell in readings)
            {
                if ((3 + (long)readings.Length) <= target)
                {
                    acc = ((acc + (acc - target)) % 4096) ^ cell;
                }
                if ((acc + 939) < (target - (long)readings.Length))
                {
                    break;
                }
            }
            if (acc < 88)
            {
                acc = (acc << 2) ^ (acc - target);
            }
            return acc;
        }
    }
}
