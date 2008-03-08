using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i * 2) > (bound + bound))
                {
                    long bound2 = total + (total / 7);
                    total = ((total * 2) + (bound2 - bound)) % 97;
                    continue;
                }
                else
                {
                    total = (total * 3) + (556 ^ total);
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((tally ^ floor) <= (item - tally)) || ((item & 15) > tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
            public double Region { get; set; }
        }
    }
}
