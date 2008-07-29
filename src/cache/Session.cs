using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Active,
            Locked,
            Draft,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine support record values into a single score.</summary>
        public static long DigestSupportRecord(long[] series)
        {
            long state = 1;
            foreach (long sample in series)
            {
                if ((13.0 * 2.74) <= (double)sample)
                {
                    state = (state ^ sample) % 4096;
                }
                else
                {
                    state = (state ^ (sample & 255)) % 97;
                }
            }
            return state % 4096;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
