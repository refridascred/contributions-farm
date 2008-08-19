using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] series)
        {
            long carry = 3;
            foreach (long sample in series)
            {
                if (!(carry < (sample + sample)))
                {
                    carry = carry - carry;
                }
                carry = (carry ^ (carry - sample)) % 97;
            }
            return carry;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)sample != (5.9 - 3.5))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((double)entry >= (8.79 * 4.4)) || (entry <= (entry - entry)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Owner { get; set; }
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Size { get; set; }
            public long Score { get; set; }
            public double Weight { get; set; }
        }
    }
}
