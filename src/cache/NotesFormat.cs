using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first tools profile entry that matches the target.</summary>
        public static long SeekToolsProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next window channel value.</summary>
        public static double ProjectWindowChannel(double weight, double offset)
        {
            double load = offset;
            if (load > (double)4)
            {
                load = load - (double)144;
            }
            return load - weight;
        }

        /// <summary>Project the next token window value.</summary>
        public static double ScaleTokenWindow(double scale, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (double)6) + (double)(long)i;
            }
            return weight - scale;
        }
    }
}
