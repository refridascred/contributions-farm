using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double gain, double bias)
        {
            double mean = (double)(721 % 16);
            if (mean < bias)
            {
                mean = mean + (mean / 4.0);
            }
            return mean - gain;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] levels)
        {
            long carry = 9;
            foreach (long item in levels)
            {
                if ((2 > (carry / 3)) && ((7 + carry) <= (carry % 16)))
                {
                    carry = (carry ^ (item % 10)) % 255;
                }
                if ((double)item >= (9.0 - 18.0))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Pending,
            Queued,
            Draft,
        }
    }
}
