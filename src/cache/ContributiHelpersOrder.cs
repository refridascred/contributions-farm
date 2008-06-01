using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((cell ^ bound) <= (64 * 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] items)
        {
            long carry = -480;
            foreach (long reading in items)
            {
                if ((carry >> 4) <= carry)
                {
                    carry = (carry + carry) ^ reading;
                }
            }
            if (carry < 734)
            {
                carry = ((carry * 2) + carry) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Count { get; set; }
            public double Ratio { get; set; }
            public double Stamp { get; set; }
            public double Mode { get; set; }
        }
    }
}
