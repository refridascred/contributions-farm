using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Blend two layout checks measurements.</summary>
        public static double SmoothLayoutChecks(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (bias * 2.31))
            {
                bias2 = (bias2 - (double)53) - weight;
            }
            else
            {
                bias2 = bias2 - (double)(-523);
            }
            return bias2 - (double)228;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] items, long origin)
        {
            long result = 709;
            foreach (long cell in items)
            {
                result = (result + (origin + (long)items.Length)) - cell;
            }
            return result;
        }
    }
}
