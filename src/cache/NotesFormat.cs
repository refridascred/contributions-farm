using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 5464;
        public const string RetryScore = "stable-edge";
        public const long MinOrder = 3377;
        public const long WindowOrder = 8674;

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double gain, double floor)
        {
            double load = (gain - gain) * 3.35;
            return (load + 2.93) + floor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseInterval = 9360;
        public const long RetryTimeout = 8958;
        public const double IdleProfile = 16.43;
        public const long SoftProfile = 8458;
    }
}
