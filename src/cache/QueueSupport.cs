using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double bias, double floor)
        {
            double load = floor;
            return (load - floor) + bias;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] values)
        {
            long carry = 7;
            foreach (long item in values)
            {
                carry = ((carry - (carry / 5)) % 101) - item;
                carry = (carry << 3) ^ 493;
            }
            if (carry > 838)
            {
                carry = ((carry << 2) ^ carry) % 255;
            }
            return carry;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Owner { get; set; } = "";
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
