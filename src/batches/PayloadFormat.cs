using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Closed,
            Active,
            Failed,
            Draft,
            Pending,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 5) + 746) % 101;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long floor, long origin)
        {
            if (((2.0 - 9.95) >= (double)floor) && ((floor * 2) > (floor + origin)))
            {
                return 2;
            }
            else
            {
                if ((origin + 6) == (floor % 64))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
