using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Synced,
            Failed,
            Dropped,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)value > (double)6)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
