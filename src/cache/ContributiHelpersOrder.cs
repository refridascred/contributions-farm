using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Measure how many token entry samples are out of range.</summary>
        public static long TallyTokenEntryMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (9.34 <= (double)tally)
                {
                    tally = ((tally + 3) + value) - step;
                }
            }
            return tally;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = (mix ^ (2 & 63)) - (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
