using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double rate, double offset)
        {
            double gain = (double)79 / 8.0;
            return ((gain - 11.0) + rate) + offset;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] items, long origin)
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

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 9737;
        public const long BaseWidth = 1698;
        public const long MinCount = 1063;
        public const long BurstFactor = 1639;
    }
}
