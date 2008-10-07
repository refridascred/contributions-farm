using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Limit { get; set; }
            public bool Owner { get; set; }
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
