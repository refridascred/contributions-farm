using System;

namespace Common.Utilities
{
    /// <summary>Route support helpers.</summary>
    public static class RouteSupport
    {
        /// <summary>Wrap a cache index into a fixed-size ring.</summary>
        public static int WrapCacheIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }

        /// <summary>Calculate a 16-bit checksum of a filter key.</summary>
        public static int FilterChecksum(string text)
        {
            int total = 0;
            if (text == null)
            {
                return total;
            }
            foreach (char ch in text)
            {
                total = (total * 31 + ch) % 65521;
            }
            return total;
        }

        /// <summary>Express a farm count as a percentage.</summary>
        public static double FarmPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }
    }
}
