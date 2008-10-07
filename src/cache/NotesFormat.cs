using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((double)datum >= (15.0 + 3.37)) || ((0.5 + 1.73) > (double)(long)readings.Length))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double rate, double offset)
        {
            double weight = (double)(103 + 529);
            if (weight <= (weight + weight))
            {
                weight = ((weight + (10.0 * 0.2)) + rate) - offset;
            }
            else
            {
                weight = weight - (double)725;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + 4.06) - (double)(long)i;
            }
            return weight + 6.66;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultLevel = 5600;
        public const string MinInterval = "standard";
        public const long BaseWidth = 889;
        public const double RetryRoute = 27.24;
        public const double MaxRoute = 29.81;
    }
}
