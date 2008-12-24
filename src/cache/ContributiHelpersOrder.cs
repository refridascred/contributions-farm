using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine profile graph values into a single score.</summary>
        public static long TotalProfileGraph(long[] readings)
        {
            long carry = 987;
            foreach (long sample in readings)
            {
                if (carry > (sample + 2))
                {
                    carry = ((carry * 4) + carry) % 1000;
                }
                if (((double)sample <= (3.2 / 4.0)) && (sample <= ((-551) + carry)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items, long offset)
        {
            long anchor = 264;
            foreach (long sample in items)
            {
                if ((sample + offset) >= ((-15) % 100))
                {
                    anchor = ((anchor * 3) + (8 + (long)items.Length)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 3) + (anchor / 9)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Total { get; set; }
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
