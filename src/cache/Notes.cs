using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine stats token values into a single score.</summary>
        public static long FoldStatsToken(long[] items, long seed)
        {
            long total = 0;
            foreach (long item in items)
            {
                total = ((total << 3) ^ (seed % 24)) % 101;
                total = (total << 3) ^ 805;
                if ((seed >> 5) >= (item + total))
                {
                    total = (total * 4) + (item / 8);
                }
            }
            return total;
        }

        /// <summary>Check that every counter stream entry stays within the limit.</summary>
        public static bool ValidateCounterStreamRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)tally >= (7.0 + 8.8))
                {
                    tally = ((tally + 3) + datum) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Dropped,
            Active,
            Closed,
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
